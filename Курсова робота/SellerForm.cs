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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\geyda\OneDrive\Documents\PC.mdf;Integrated Security=True;Connect Timeout=30");


        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select*from Seller";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SID.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            SName.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            SAge.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            Sphone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            SPassword.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Seller values(" + SID.Text + ",'" + SName.Text + "'," + SAge.Text + "," + Sphone.Text + ",'" + SPassword + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Аккаунт додано успішно");
                Con.Close();
                populate();
                SID.Text = "";
                SName.Text = "";
                Sphone.Text = "";
                SPassword.Text = "";
                SAge.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (SID.Text == "")
                {
                    MessageBox.Show("Select the Seller to delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Seller where SID="+SID.Text+"";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Delete Successfully");
                    Con.Close();
                    populate();
                    SID.Text = "";
                    SName.Text = "";
                    Sphone.Text = "";
                    SPassword.Text = "";
                    SAge.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (SName.Text == "" || SID.Text == "" || Sphone.Text == "" || SPassword.Text =="")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "Update Seller set SName='" + SName.Text + "',SAge='" + SAge.Text + "' Sphone=" + Sphone.Text + "'Spass'"+SPassword.Text+"'where sellerId="+SID.Text+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller successfully updated ");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CATEGORYFORM cat = new CATEGORYFORM();
            cat.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }
    }
}
