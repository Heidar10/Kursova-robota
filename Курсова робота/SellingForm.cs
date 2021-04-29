using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Курсова_робота
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\geyda\OneDrive\Documents\PC.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
                Con.Open();
                string query = "select Виробництво,Кількість from Product";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProdDGV1.DataSource = ds.Tables[0];
                Con.Close();
        }
        private void populateTbl()
        {
            Con.Open();
            string query = "select * from SellingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReeiptDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populateTbl();
            populate();
            fillcombo();
        }
        

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
           
        private void ProdGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Producer.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            Number.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
            Price.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
      int Grdtotal = 0, n = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            if (Sld.Text == "")
            {
                MessageBox.Show("Відсутній ідентифікатор рахунку");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into SellingTbl values(" + Sld.Text + ",'" + SellerNameTbl.Text + "','" + Datelbl.Text + "'," + Amtlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Замовлення додано успішно");
                    Con.Close();
                    populateTbl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PC assembly", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID:" + ReeiptDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name:" + ReeiptDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date:" + ReeiptDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount:" + ReeiptDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void SearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select Типи комплект.,Приклад виробника where Категорія='" + SearchCb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fillcombo()
        {
            //Con.Open();
            //SqlCommand cmd = new SqlCommand("select 'Типикомплектуючи' from Category", Con);
            //SqlDataReader rdr;
            //rdr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Типикомплектуючи", typeof(string));
            //dt.Load(rdr);
            ////CatCb.ValueMember = "Типикомплектуючи";
            ////CatCb.DataSource = dt;
            //SearchCb.ValueMember = "Типикомплектуючи";
            //SearchCb.DataSource = dt;
            //Con.Close();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select 'Типикомплектуючи' from Category", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Типикомплектуючи", typeof(string));
            dt.Load(rdr);
            //CatCb.ValueMember = "Типикомплектуючи";
            //CatCb.DataSource = dt;

            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Producer.Text == "" || Number.Text == "")
            {
                MessageBox.Show("Missing data");
            }
            else
            {
                int total= Convert.ToInt32(Price.Text) * Convert.ToInt32(Number.Text);
                //int Grdtotal = 0;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = Producer.Text;
                newRow.Cells[2].Value = Price.Text;
                newRow.Cells[3].Value = Number.Text;
                newRow.Cells[3].Value = Convert.ToInt32(Price.Text) * Convert.ToInt32(Number.Text);
                ORDERDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amtlbl.Text = "" + Grdtotal;
            }
        }

        
    }
}
