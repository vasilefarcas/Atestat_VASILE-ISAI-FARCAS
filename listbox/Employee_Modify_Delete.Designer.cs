
namespace LICENTA_VASILE_ISAI_FARCAS
{
    partial class Modify_Delete_Shop_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modify_Delete_Shop_Form));
            this.comboBox_EmployeeSelect = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_EmployeeSelect = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Role = new System.Windows.Forms.Label();
            this.label_Shop = new System.Windows.Forms.Label();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.comboBox_Store = new System.Windows.Forms.ComboBox();
            this.label_EmployeeId = new System.Windows.Forms.Label();
            this.label_Id_Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_EmployeeSelect
            // 
            this.comboBox_EmployeeSelect.FormattingEnabled = true;
            this.comboBox_EmployeeSelect.Location = new System.Drawing.Point(105, 10);
            this.comboBox_EmployeeSelect.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_EmployeeSelect.Name = "comboBox_EmployeeSelect";
            this.comboBox_EmployeeSelect.Size = new System.Drawing.Size(169, 21);
            this.comboBox_EmployeeSelect.TabIndex = 0;
            this.comboBox_EmployeeSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(60, 40);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(156, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(60, 70);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(127, 20);
            this.textBox_Email.TabIndex = 2;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(10, 45);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Nume";
            // 
            // label_EmployeeSelect
            // 
            this.label_EmployeeSelect.AutoSize = true;
            this.label_EmployeeSelect.Location = new System.Drawing.Point(10, 15);
            this.label_EmployeeSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_EmployeeSelect.Name = "label_EmployeeSelect";
            this.label_EmployeeSelect.Size = new System.Drawing.Size(86, 13);
            this.label_EmployeeSelect.TabIndex = 4;
            this.label_EmployeeSelect.Text = "Select Employee";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(10, 75);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 5;
            this.label_Email.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modifica date";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(138, 160);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sterge";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(261, 160);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 27);
            this.button3.TabIndex = 10;
            this.button3.Text = "Iesire";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            this.label5.Visible = false;
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(10, 105);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(29, 13);
            this.label_Role.TabIndex = 12;
            this.label_Role.Text = "Role";
            // 
            // label_Shop
            // 
            this.label_Shop.AutoSize = true;
            this.label_Shop.Location = new System.Drawing.Point(10, 135);
            this.label_Shop.Name = "label_Shop";
            this.label_Shop.Size = new System.Drawing.Size(32, 13);
            this.label_Shop.TabIndex = 13;
            this.label_Shop.Text = "Store";
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Location = new System.Drawing.Point(60, 100);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Role.TabIndex = 14;
            // 
            // comboBox_Store
            // 
            this.comboBox_Store.FormattingEnabled = true;
            this.comboBox_Store.Location = new System.Drawing.Point(60, 130);
            this.comboBox_Store.Name = "comboBox_Store";
            this.comboBox_Store.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Store.TabIndex = 15;
            // 
            // label_EmployeeId
            // 
            this.label_EmployeeId.AutoSize = true;
            this.label_EmployeeId.Location = new System.Drawing.Point(223, 43);
            this.label_EmployeeId.Name = "label_EmployeeId";
            this.label_EmployeeId.Size = new System.Drawing.Size(18, 13);
            this.label_EmployeeId.TabIndex = 16;
            this.label_EmployeeId.Text = "ID";
            // 
            // label_Id_Value
            // 
            this.label_Id_Value.AutoSize = true;
            this.label_Id_Value.Location = new System.Drawing.Point(247, 43);
            this.label_Id_Value.Name = "label_Id_Value";
            this.label_Id_Value.Size = new System.Drawing.Size(77, 13);
            this.label_Id_Value.TabIndex = 17;
            this.label_Id_Value.Text = "label_Id_Value";
            // 
            // Modify_Delete_Shop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 199);
            this.Controls.Add(this.label_Id_Value);
            this.Controls.Add(this.label_EmployeeId);
            this.Controls.Add(this.comboBox_Store);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.label_Shop);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_EmployeeSelect);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.comboBox_EmployeeSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Modify_Delete_Shop_Form";
            this.Text = "Modify Delete Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_EmployeeSelect;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_EmployeeSelect;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.Label label_Shop;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.ComboBox comboBox_Store;
        private System.Windows.Forms.Label label_EmployeeId;
        private System.Windows.Forms.Label label_Id_Value;
    }
}