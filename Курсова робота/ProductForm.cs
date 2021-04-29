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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\geyda\OneDrive\Documents\PC.mdf;Integrated Security=True;Connect Timeout=30");
        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select 'Типикомплектуючи' from Category", Con);
            SqlDataReader rdr;
            rdr= cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Типикомплектуючи", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "Типикомплектуючи";
            CatCb.DataSource = dt;
            SearchCb.ValueMember = "Типикомплектуючи";
            SearchCb.DataSource = dt;
            Con.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        //
        private void populate()
        {
            Con.Open();
            string query = "select * from Product";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ProdDGV_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CATEGORYFORM cat = new CATEGORYFORM();
            cat.Show();
            this.Hide();
        }
        //

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Product values(" +Prodld.Text + ",'" + Producer.Text + "'," +Number.Text+","+Price.Text+",'"+CatCb.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Комлектуючи додано успішно");
                Con.Close();
                //populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Prodld.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            Producer.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString(); 
            Number.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            Price.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
       }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (Prodld.Text=="")
                {
                    MessageBox.Show("Select the product to delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Product where ProdId=" + Prodld.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Delete Successfully");
                    Con.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void SearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from Product where Категорія='" + SearchCb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
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
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }

        
    }
}
