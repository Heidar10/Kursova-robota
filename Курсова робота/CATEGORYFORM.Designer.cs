
namespace Курсова_робота
{
    partial class CATEGORYFORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CategoryTbl = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Редагувати = new System.Windows.Forms.Button();
            this.Видалити = new System.Windows.Forms.Button();
            this.Додати = new System.Windows.Forms.Button();
            this.Прикладвиробництва = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Типикомплектуючи = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTbl)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(188)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.CategoryTbl);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.Редагувати);
            this.panel2.Controls.Add(this.Видалити);
            this.panel2.Controls.Add(this.Додати);
            this.panel2.Controls.Add(this.Прикладвиробництва);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.Типикомплектуючи);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 645);
            this.panel2.TabIndex = 48;
            // 
            // CategoryTbl
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CategoryTbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryTbl.BackgroundColor = System.Drawing.Color.White;
            this.CategoryTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CategoryTbl.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryTbl.DefaultCellStyle = dataGridViewCellStyle6;
            this.CategoryTbl.EnableHeadersVisualStyles = false;
            this.CategoryTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryTbl.Location = new System.Drawing.Point(586, 156);
            this.CategoryTbl.Name = "CategoryTbl";
            this.CategoryTbl.RowHeadersVisible = false;
            this.CategoryTbl.RowHeadersWidth = 51;
            this.CategoryTbl.RowTemplate.Height = 28;
            this.CategoryTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryTbl.Size = new System.Drawing.Size(558, 477);
            this.CategoryTbl.TabIndex = 27;
            this.CategoryTbl.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CategoryTbl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoryTbl.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoryTbl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoryTbl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoryTbl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoryTbl.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoryTbl.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryTbl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CategoryTbl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoryTbl.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryTbl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoryTbl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoryTbl.ThemeStyle.HeaderStyle.Height = 30;
            this.CategoryTbl.ThemeStyle.ReadOnly = false;
            this.CategoryTbl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoryTbl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryTbl.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryTbl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoryTbl.ThemeStyle.RowsStyle.Height = 28;
            this.CategoryTbl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryTbl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 645);
            this.panel4.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Комплектуючи";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Адміни";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Редагувати
            // 
            this.Редагувати.BackColor = System.Drawing.Color.Red;
            this.Редагувати.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Редагувати.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.Редагувати.Location = new System.Drawing.Point(194, 427);
            this.Редагувати.Name = "Редагувати";
            this.Редагувати.Size = new System.Drawing.Size(152, 37);
            this.Редагувати.TabIndex = 24;
            this.Редагувати.Text = "Редагувати";
            this.Редагувати.UseVisualStyleBackColor = false;
            this.Редагувати.Click += new System.EventHandler(this.Редагувати_Click);
            // 
            // Видалити
            // 
            this.Видалити.BackColor = System.Drawing.Color.Red;
            this.Видалити.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Видалити.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.Видалити.Location = new System.Drawing.Point(194, 481);
            this.Видалити.Name = "Видалити";
            this.Видалити.Size = new System.Drawing.Size(152, 37);
            this.Видалити.TabIndex = 23;
            this.Видалити.Text = "Видалити";
            this.Видалити.UseVisualStyleBackColor = false;
            this.Видалити.Click += new System.EventHandler(this.Видалити_Click);
            // 
            // Додати
            // 
            this.Додати.BackColor = System.Drawing.Color.Red;
            this.Додати.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Додати.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.Додати.Location = new System.Drawing.Point(194, 366);
            this.Додати.Name = "Додати";
            this.Додати.Size = new System.Drawing.Size(129, 37);
            this.Додати.TabIndex = 22;
            this.Додати.Text = "Додати";
            this.Додати.UseVisualStyleBackColor = false;
            this.Додати.Click += new System.EventHandler(this.Додати_Click);
            // 
            // Прикладвиробництва
            // 
            this.Прикладвиробництва.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Прикладвиробництва.Location = new System.Drawing.Point(421, 317);
            this.Прикладвиробництва.Name = "Прикладвиробництва";
            this.Прикладвиробництва.Size = new System.Drawing.Size(122, 30);
            this.Прикладвиробництва.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(189, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 27);
            this.label13.TabIndex = 8;
            this.label13.Text = "Приклад виробника";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Типикомплектуючи
            // 
            this.Типикомплектуючи.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Типикомплектуючи.Location = new System.Drawing.Point(421, 276);
            this.Типикомплектуючи.Name = "Типикомплектуючи";
            this.Типикомплектуючи.Size = new System.Drawing.Size(122, 30);
            this.Типикомплектуючи.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(189, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 27);
            this.label14.TabIndex = 6;
            this.label14.Text = "Типи комлект.";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.Location = new System.Drawing.Point(421, 231);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(122, 30);
            this.ID.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(189, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "ID";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 65);
            this.panel1.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 18F);
            this.label16.Location = new System.Drawing.Point(964, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 36);
            this.label16.TabIndex = 4;
            this.label16.Text = "x";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(384, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(293, 33);
            this.label17.TabIndex = 3;
            this.label17.Text = "Типи комплектуючих";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label18.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(558, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 36);
            this.label18.TabIndex = 2;
            this.label18.Text = "x";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 31;
            this.label2.Text = "Вийти";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CATEGORYFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 645);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CATEGORYFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORYFORM";
            this.Load += new System.EventHandler(this.CATEGORYFORM_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTbl)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Редагувати;
        private System.Windows.Forms.Button Видалити;
        private System.Windows.Forms.Button Додати;
        private System.Windows.Forms.TextBox Прикладвиробництва;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Типикомплектуючи;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2DataGridView CategoryTbl;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label2;
    }
}