namespace LICENTA_VASILE_ISAI_FARCAS
{
    partial class Item_Modify_Delete
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
            System.Windows.Forms.Button button_CancelSearch;
            this.label_Description = new System.Windows.Forms.Label();
            this.label_ItemId_Value = new System.Windows.Forms.Label();
            this.dataGridView_Stock = new System.Windows.Forms.DataGridView();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_ItemId = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            button_CancelSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CancelSearch
            // 
            button_CancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_CancelSearch.Location = new System.Drawing.Point(380, 27);
            button_CancelSearch.Margin = new System.Windows.Forms.Padding(2);
            button_CancelSearch.Name = "button_CancelSearch";
            button_CancelSearch.Size = new System.Drawing.Size(66, 24);
            button_CancelSearch.TabIndex = 46;
            button_CancelSearch.Text = "Cancel";
            button_CancelSearch.UseVisualStyleBackColor = true;
            button_CancelSearch.Click += new System.EventHandler(this.button_CancelSearch_Click);
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(20, 300);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(60, 13);
            this.label_Description.TabIndex = 56;
            this.label_Description.Text = "Description";
            // 
            // label_ItemId_Value
            // 
            this.label_ItemId_Value.AutoSize = true;
            this.label_ItemId_Value.Location = new System.Drawing.Point(85, 250);
            this.label_ItemId_Value.Name = "label_ItemId_Value";
            this.label_ItemId_Value.Size = new System.Drawing.Size(97, 13);
            this.label_ItemId_Value.TabIndex = 54;
            this.label_ItemId_Value.Text = "label_ItemId_Value";
            // 
            // dataGridView_Stock
            // 
            this.dataGridView_Stock.AllowUserToAddRows = false;
            this.dataGridView_Stock.AllowUserToDeleteRows = false;
            this.dataGridView_Stock.AllowUserToOrderColumns = true;
            this.dataGridView_Stock.AllowUserToResizeRows = false;
            this.dataGridView_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Stock.Location = new System.Drawing.Point(22, 56);
            this.dataGridView_Stock.MultiSelect = false;
            this.dataGridView_Stock.Name = "dataGridView_Stock";
            this.dataGridView_Stock.ReadOnly = true;
            this.dataGridView_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Stock.Size = new System.Drawing.Size(760, 185);
            this.dataGridView_Stock.TabIndex = 53;
            this.dataGridView_Stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Stock_CellClick);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(492, 270);
            this.textBox_Price.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(197, 20);
            this.textBox_Price.TabIndex = 51;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(420, 275);
            this.label_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(31, 13);
            this.label_Price.TabIndex = 49;
            this.label_Price.Text = "Price";
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Location = new System.Drawing.Point(492, 245);
            this.textBox_ItemName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(197, 20);
            this.textBox_ItemName.TabIndex = 48;
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Location = new System.Drawing.Point(420, 250);
            this.label_ItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(56, 13);
            this.label_ItemName.TabIndex = 47;
            this.label_ItemName.Text = "Item name";
            // 
            // button_Exit
            // 
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Location = new System.Drawing.Point(655, 322);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(127, 39);
            this.button_Exit.TabIndex = 45;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modify.Location = new System.Drawing.Point(23, 322);
            this.button_Modify.Margin = new System.Windows.Forms.Padding(2);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(490, 39);
            this.button_Modify.TabIndex = 44;
            this.button_Modify.Text = "Modify";
            this.button_Modify.UseVisualStyleBackColor = false;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(20, 275);
            this.label_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(49, 13);
            this.label_Category.TabIndex = 43;
            this.label_Category.Text = "Category";
            // 
            // label_ItemId
            // 
            this.label_ItemId.AutoSize = true;
            this.label_ItemId.Location = new System.Drawing.Point(20, 250);
            this.label_ItemId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ItemId.Name = "label_ItemId";
            this.label_ItemId.Size = new System.Drawing.Size(39, 13);
            this.label_ItemId.TabIndex = 41;
            this.label_ItemId.Text = "Item Id";
            // 
            // button_Search
            // 
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Location = new System.Drawing.Point(305, 27);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(73, 24);
            this.button_Search.TabIndex = 40;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(120, 30);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(178, 20);
            this.textBox_Search.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search item by ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Modify item";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Location = new System.Drawing.Point(517, 322);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(134, 39);
            this.button_Delete.TabIndex = 59;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(85, 270);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(190, 21);
            this.comboBox_Category.TabIndex = 60;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(85, 295);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(693, 20);
            this.textBox_Description.TabIndex = 61;
            // 
            // Item_Modify_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 391);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_ItemId_Value);
            this.Controls.Add(this.dataGridView_Stock);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.textBox_ItemName);
            this.Controls.Add(this.label_ItemName);
            this.Controls.Add(button_CancelSearch);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_ItemId);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Item_Modify_Delete";
            this.Text = "Item_Modify_Delete";
            this.Load += new System.EventHandler(this.Item_Modify_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_ItemId_Value;
        private System.Windows.Forms.DataGridView dataGridView_Stock;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_ItemId;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.TextBox textBox_Description;
    }
}