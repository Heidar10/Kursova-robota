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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Sellername = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\geyda\OneDrive\Documents\PC.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter The UserName And Password");
            }
            else
            {
                if (RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "ADMIN")
                    {
                        if (UnameTb.Text == "Admin" && PassTb.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are the Admin, Enter The Correct Id and Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your in the seller selection");
                        //Con.Open();
                        //SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from Seller where Ім'я='" + UnameTb.Text + "'and Пароль='" + PassTb.Text + "'", Con);
                        //DataTable dt = new DataTable();
                        //sda.Fill(dt);
                        if ((UnameTb.Text == "Ivan" && PassTb.Text == "Ivan"))//(dt.Rows[0][0].ToString() == "1")
                        {
                            //Sellername = UnameTb.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            Con.Close();

                        }
                        //else
                        //{
                        //    MessageBox.Show("Неправильне ім'я користувача або пароль");

                        //}

                        //Con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Select a role");
                }

            }
           
        }

         private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
         {

         }
        
        private void RoleCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
}
