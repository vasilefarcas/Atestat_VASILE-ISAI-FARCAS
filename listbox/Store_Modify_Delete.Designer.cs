
namespace LICENTA_VASILE_ISAI_FARCAS
{
    partial class Store_Modify_Delete_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store_Modify_Delete_Form));
            this.comboBox_Shop = new System.Windows.Forms.ComboBox();
            this.label_Shop = new System.Windows.Forms.Label();
            this.label_ShopName = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_StoreId_Value = new System.Windows.Forms.Label();
            this.label_StoreId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Shop
            // 
            this.comboBox_Shop.FormattingEnabled = true;
            this.comboBox_Shop.Location = new System.Drawing.Point(100, 10);
            this.comboBox_Shop.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Shop.Name = "comboBox_Shop";
            this.comboBox_Shop.Size = new System.Drawing.Size(158, 21);
            this.comboBox_Shop.TabIndex = 0;
            this.comboBox_Shop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_Shop
            // 
            this.label_Shop.AutoSize = true;
            this.label_Shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Shop.Location = new System.Drawing.Point(10, 10);
            this.label_Shop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Shop.Name = "label_Shop";
            this.label_Shop.Size = new System.Drawing.Size(47, 20);
            this.label_Shop.TabIndex = 1;
            this.label_Shop.Text = "Shop";
            // 
            // label_ShopName
            // 
            this.label_ShopName.AutoSize = true;
            this.label_ShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShopName.Location = new System.Drawing.Point(10, 70);
            this.label_ShopName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ShopName.Name = "label_ShopName";
            this.label_ShopName.Size = new System.Drawing.Size(48, 18);
            this.label_ShopName.TabIndex = 2;
            this.label_ShopName.Text = "Name";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.Location = new System.Drawing.Point(10, 100);
            this.label_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(62, 18);
            this.label_Address.TabIndex = 3;
            this.label_Address.Text = "Address";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(100, 70);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(151, 20);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(100, 100);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(158, 20);
            this.textBox_Address.TabIndex = 6;
            // 
            // button_Modify
            // 
            this.button_Modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modify.Location = new System.Drawing.Point(17, 127);
            this.button_Modify.Margin = new System.Windows.Forms.Padding(2);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(120, 29);
            this.button_Modify.TabIndex = 8;
            this.button_Modify.Text = "Modify";
            this.button_Modify.UseVisualStyleBackColor = false;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Location = new System.Drawing.Point(145, 127);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 29);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Location = new System.Drawing.Point(17, 159);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(248, 29);
            this.button_Exit.TabIndex = 10;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_StoreId_Value
            // 
            this.label_StoreId_Value.AutoSize = true;
            this.label_StoreId_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoreId_Value.Location = new System.Drawing.Point(100, 40);
            this.label_StoreId_Value.Name = "label_StoreId_Value";
            this.label_StoreId_Value.Size = new System.Drawing.Size(137, 18);
            this.label_StoreId_Value.TabIndex = 12;
            this.label_StoreId_Value.Text = "label_StoreId_Value";
            // 
            // label_StoreId
            // 
            this.label_StoreId.AutoSize = true;
            this.label_StoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoreId.Location = new System.Drawing.Point(10, 40);
            this.label_StoreId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StoreId.Name = "label_StoreId";
            this.label_StoreId.Size = new System.Drawing.Size(62, 18);
            this.label_StoreId.TabIndex = 13;
            this.label_StoreId.Text = "Store ID";
            // 
            // Store_Modify_Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 204);
            this.Controls.Add(this.label_StoreId);
            this.Controls.Add(this.label_StoreId_Value);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_ShopName);
            this.Controls.Add(this.label_Shop);
            this.Controls.Add(this.comboBox_Shop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Store_Modify_Delete_Form";
            this.Text = "Employee Modify Delete";
            this.Load += new System.EventHandler(this.Modify_Delete_Employee_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Shop;
        private System.Windows.Forms.Label label_Shop;
        private System.Windows.Forms.Label label_ShopName;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_StoreId_Value;
        private System.Windows.Forms.Label label_StoreId;
    }
}