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
    public partial class CATEGORYFORM : Form
    {
        public CATEGORYFORM()
        {
            InitializeComponent();
        }
        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\geyda\OneDrive\Documents\PC.mdf;Integrated Security=True;Connect Timeout=30");
        private void Додати_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Category values(" + ID.Text + ",'" + Типикомплектуючи.Text + "','" + Прикладвиробництва.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Категорію додано успішно");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void populate()
        {
            Con.Open();
            string query = "select*from Category";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CategoryTbl.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CATEGORYFORM_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CategoryTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = CategoryTbl.SelectedRows[0].Cells[0].Value.ToString();
            Типикомплектуючи.Text = CategoryTbl.SelectedRows[0].Cells[1].Value.ToString();
            Прикладвиробництва.Text = CategoryTbl.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Видалити_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Text == "")
                {
                    MessageBox.Show("Виберіть категорію для видалення");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Category where Catd=" + ID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Категорію успішно видалено");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Редагувати_Click(object sender, EventArgs e)
        {
            try
            {
                if(ID.Text==""|| Типикомплектуючи.Text == "" || Прикладвиробництва.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "Update Category set Типи комплект.='" + Типикомплектуючи.Text + "',Приклад виробництва='" + Прикладвиробництва.Text + "' where Category=" + ID.Text + ":";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfully updated ");
                    Con.Close();
                    populate();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }


        //private void Додати_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Con.Open();
        //        string query = "insert into Category values(" + ID.Text + ",'" + Типикомплектуючи.Text + "','" + Прикладвиробництва.Text + "')";
        //        SqlCommand cmd = new SqlCommand(query,Con);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Категорію додано успішно");
        //        Con.Close();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void label16_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void populate()
        //{
        //    Con.Open();
        //    string query = "select*from Category";
        //    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        //    var ds = new DataSet();
        //    sda.Fill(ds);
        //    Category.DataSource = ds.Tables[0];
        //    Con.Close();
        //}

        //private void CATEGORYFORM_Load(object sender, EventArgs e)
        //{
        //    populate();
        //}

        //private void Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    ID.Text = Category.SelectedRows[2].Cells[2].Value.ToString();
        //    Типикомплектуючи.Text = Category.SelectedRows[3].Cells[3].Value.ToString();
        //    Прикладвиробництва.Text = Category.SelectedRows[4].Cells[4].Value.ToString();
        //}

        //private void Видалити_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (ID.Text == "")
        //        {
        //            MessageBox.Show("Виберіть категорію для видалення");
        //        }
        //        else
        //        {
        //            Con.Open();
        //            string query = "delete from Category where Catd=" + ID.Text + "";
        //            SqlCommand cmd = new SqlCommand(query, Con);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Категорію успішно видалено");
        //            Con.Close();
        //            populate();
        //        }
        //    }catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void Редагувати_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Con.Open();
        //        string query = "Update Category set Типи комплект.='" + Типикомплектуючи.Text + "',Приклад виробництва='" + Прикладвиробництва.Text + "' where Category=" + ID.Text + ":";
        //        SqlCommand cmd = new SqlCommand(query,Con);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Category successfully updated ");
        //        Con.Close();
        //    }catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}



        //////////
        /* private void Додати_Click(object sender, EventArgs e)
         {
             try
             {
                 Con.Open();
                 string query = "insert into Category values(" + ID.Text + ",'" + Типикомплектуючи.Text + "','" + Прикладвиробництва.Text + "')";
                 SqlCommand cmd = new SqlCommand(query, Con);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Категорію додано успішно");
                 Con.Close();
                 populate();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }



         private void populate()
         {
             Con.Open();
             string query = "select*from Category";
             SqlDataAdapter sda = new SqlDataAdapter(query, Con);
             SqlCommandBuilder builder = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);
             CategoryTbl.DataSource = ds.Tables[0];
             Con.Close();
         }

         private void CATEGORYFORM_Load(object sender, EventArgs e)
         {
             populate();
         }

         private void CategoryTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             ID.Text = CategoryTbl.SelectedRows[0].Cells[0].Value.ToString();
             Типикомплектуючи.Text = CategoryTbl.SelectedRows[0].Cells[1].Value.ToString();
             Прикладвиробництва.Text = CategoryTbl.SelectedRows[0].Cells[2].Value.ToString();
         }

         private void Видалити_Click(object sender, EventArgs e)
         {
             try
             {
                 if (ID.Text == "")
                 {
                     MessageBox.Show("Виберіть категорію для видалення");
                 }
                 else
                 {
                     Con.Open();
                     string query = "delete from Category where Catd=" + ID.Text + "";
                     SqlCommand cmd = new SqlCommand(query, Con);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Категорію успішно видалено");
                     Con.Close();
                     populate();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }

         private void Редагувати_Click(object sender, EventArgs e)
         {
             try
             {
                 if (ID.Text == "" || Типикомплектуючи.Text == "" || Прикладвиробництва.Text == "")
                 {
                     MessageBox.Show("Missing information");
                 }
                 else
                 {
                     Con.Open();
                     string query = "Update Category set Типи комплект.='" + Типикомплектуючи.Text + "',Приклад виробництва='" + Прикладвиробництва.Text + "' where Category=" + ID.Text + ":";
                     SqlCommand cmd = new SqlCommand(query, Con);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Category successfully updated ");
                     Con.Close();
                     populate();
                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }

         private void button3_Click(object sender, EventArgs e)
         {
             ProductForm prod = new ProductForm();
             prod.Show();
             this.Hide();
         }
        */
    }
}
