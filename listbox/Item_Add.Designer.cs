
using System;

namespace LICENTA_VASILE_ISAI_FARCAS
{
    partial class Add_Item_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Item_Form));
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Product_Name = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.textBox_Product_Price = new System.Windows.Forms.TextBox();
            this.label_Category = new System.Windows.Forms.Label();
            this.comboBox_Product_Category = new System.Windows.Forms.ComboBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Product_Description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(5, 6);
            this.label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(85, 24);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Item data";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(9, 36);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // textBox_Product_Name
            // 
            this.textBox_Product_Name.Location = new System.Drawing.Point(9, 52);
            this.textBox_Product_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Product_Name.Name = "textBox_Product_Name";
            this.textBox_Product_Name.Size = new System.Drawing.Size(148, 20);
            this.textBox_Product_Name.TabIndex = 2;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(9, 120);
            this.label_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(31, 13);
            this.label_Price.TabIndex = 5;
            this.label_Price.Text = "Price";
            // 
            // textBox_Product_Price
            // 
            this.textBox_Product_Price.Location = new System.Drawing.Point(9, 136);
            this.textBox_Product_Price.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Product_Price.Name = "textBox_Product_Price";
            this.textBox_Product_Price.Size = new System.Drawing.Size(88, 20);
            this.textBox_Product_Price.TabIndex = 6;
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(9, 79);
            this.label_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(49, 13);
            this.label_Category.TabIndex = 7;
            this.label_Category.Text = "Category";
            // 
            // comboBox_Product_Category
            // 
            this.comboBox_Product_Category.FormattingEnabled = true;
            this.comboBox_Product_Category.Location = new System.Drawing.Point(9, 97);
            this.comboBox_Product_Category.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Product_Category.Name = "comboBox_Product_Category";
            this.comboBox_Product_Category.Size = new System.Drawing.Size(101, 21);
            this.comboBox_Product_Category.TabIndex = 8;
            // 
            // button_Insert
            // 
            this.button_Insert.BackColor = System.Drawing.Color.LawnGreen;
            this.button_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insert.Location = new System.Drawing.Point(9, 206);
            this.button_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(148, 39);
            this.button_Insert.TabIndex = 11;
            this.button_Insert.Text = "Load";
            this.button_Insert.UseVisualStyleBackColor = false;
            this.button_Insert.Click += new System.EventHandler(this.button_Add_Item_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(161, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Form_Dispose_Click);
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(9, 158);
            this.label_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(60, 13);
            this.label_Description.TabIndex = 13;
            this.label_Description.Text = "Description";
            // 
            // textBox_Product_Description
            // 
            this.textBox_Product_Description.Location = new System.Drawing.Point(9, 173);
            this.textBox_Product_Description.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Product_Description.Name = "textBox_Product_Description";
            this.textBox_Product_Description.Size = new System.Drawing.Size(244, 20);
            this.textBox_Product_Description.TabIndex = 14;
            // 
            // Add_Item_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 258);
            this.Controls.Add(this.textBox_Product_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.comboBox_Product_Category);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.textBox_Product_Price);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.textBox_Product_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Add_Item_Form";
            this.Text = "New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Product_Name;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox textBox_Product_Price;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.ComboBox comboBox_Product_Category;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.TextBox textBox_Product_Description;
    }
}