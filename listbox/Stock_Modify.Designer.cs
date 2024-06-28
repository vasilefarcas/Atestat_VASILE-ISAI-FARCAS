
namespace LICENTA_VASILE_ISAI_FARCAS
{
    partial class Check_Stock_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Stock_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_ItemId = new System.Windows.Forms.Label();
            this.label_Store = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.dataGridView_Stock = new System.Windows.Forms.DataGridView();
            this.label_ItemId_Value = new System.Windows.Forms.Label();
            this.label_Store_Value = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Description_Value = new System.Windows.Forms.Label();
            this.label_Category_Value = new System.Windows.Forms.Label();
            this.label_ItemName_Value = new System.Windows.Forms.Label();
            this.label_Price_Value = new System.Windows.Forms.Label();
            button_CancelSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CancelSearch
            // 
            button_CancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_CancelSearch.Location = new System.Drawing.Point(379, 32);
            button_CancelSearch.Margin = new System.Windows.Forms.Padding(2);
            button_CancelSearch.Name = "button_CancelSearch";
            button_CancelSearch.Size = new System.Drawing.Size(66, 24);
            button_CancelSearch.TabIndex = 18;
            button_CancelSearch.Text = "Cancel";
            button_CancelSearch.UseVisualStyleBackColor = true;
            button_CancelSearch.Click += new System.EventHandler(this.button_CancelSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify stock";
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(7, 36);
            this.label_Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(91, 13);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Search item by ID";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(120, 33);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(178, 20);
            this.textBox_Search.TabIndex = 2;
            // 
            // button_Search
            // 
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Location = new System.Drawing.Point(302, 32);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(73, 24);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_ItemId
            // 
            this.label_ItemId.AutoSize = true;
            this.label_ItemId.Location = new System.Drawing.Point(10, 260);
            this.label_ItemId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ItemId.Name = "label_ItemId";
            this.label_ItemId.Size = new System.Drawing.Size(39, 13);
            this.label_ItemId.TabIndex = 9;
            this.label_ItemId.Text = "Item Id";
            // 
            // label_Store
            // 
            this.label_Store.AutoSize = true;
            this.label_Store.Location = new System.Drawing.Point(10, 285);
            this.label_Store.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Store.Name = "label_Store";
            this.label_Store.Size = new System.Drawing.Size(32, 13);
            this.label_Store.TabIndex = 10;
            this.label_Store.Text = "Store";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(10, 310);
            this.label_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(49, 13);
            this.label_Category.TabIndex = 11;
            this.label_Category.Text = "Category";
            // 
            // button_Modify
            // 
            this.button_Modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modify.Location = new System.Drawing.Point(9, 363);
            this.button_Modify.Margin = new System.Windows.Forms.Padding(2);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(628, 39);
            this.button_Modify.TabIndex = 15;
            this.button_Modify.Text = "Modify";
            this.button_Modify.UseVisualStyleBackColor = false;
            this.button_Modify.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Location = new System.Drawing.Point(641, 363);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(127, 39);
            this.button_Exit.TabIndex = 17;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Location = new System.Drawing.Point(431, 260);
            this.label_ItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(56, 13);
            this.label_ItemName.TabIndex = 19;
            this.label_ItemName.Text = "Item name";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(431, 285);
            this.label_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(31, 13);
            this.label_Price.TabIndex = 21;
            this.label_Price.Text = "Price";
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(431, 310);
            this.label_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(46, 13);
            this.label_Quantity.TabIndex = 22;
            this.label_Quantity.Text = "Quantity";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(513, 308);
            this.textBox_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(121, 20);
            this.textBox_Quantity.TabIndex = 24;
            // 
            // dataGridView_Stock
            // 
            this.dataGridView_Stock.AllowUserToAddRows = false;
            this.dataGridView_Stock.AllowUserToDeleteRows = false;
            this.dataGridView_Stock.AllowUserToOrderColumns = true;
            this.dataGridView_Stock.AllowUserToResizeRows = false;
            this.dataGridView_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Stock.Location = new System.Drawing.Point(8, 61);
            this.dataGridView_Stock.MultiSelect = false;
            this.dataGridView_Stock.Name = "dataGridView_Stock";
            this.dataGridView_Stock.ReadOnly = true;
            this.dataGridView_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Stock.Size = new System.Drawing.Size(760, 185);
            this.dataGridView_Stock.TabIndex = 29;
            this.dataGridView_Stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Stock_CellClick);
            // 
            // label_ItemId_Value
            // 
            this.label_ItemId_Value.AutoSize = true;
            this.label_ItemId_Value.Location = new System.Drawing.Point(75, 260);
            this.label_ItemId_Value.Name = "label_ItemId_Value";
            this.label_ItemId_Value.Size = new System.Drawing.Size(97, 13);
            this.label_ItemId_Value.TabIndex = 32;
            this.label_ItemId_Value.Text = "label_ItemId_Value";
            // 
            // label_Store_Value
            // 
            this.label_Store_Value.AutoSize = true;
            this.label_Store_Value.Location = new System.Drawing.Point(75, 285);
            this.label_Store_Value.Name = "label_Store_Value";
            this.label_Store_Value.Size = new System.Drawing.Size(93, 13);
            this.label_Store_Value.TabIndex = 33;
            this.label_Store_Value.Text = "label_Store_Value";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(9, 335);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(60, 13);
            this.label_Description.TabIndex = 34;
            this.label_Description.Text = "Description";
            // 
            // label_Description_Value
            // 
            this.label_Description_Value.AutoSize = true;
            this.label_Description_Value.Location = new System.Drawing.Point(75, 335);
            this.label_Description_Value.Name = "label_Description_Value";
            this.label_Description_Value.Size = new System.Drawing.Size(121, 13);
            this.label_Description_Value.TabIndex = 35;
            this.label_Description_Value.Text = "label_Description_Value";
            // 
            // label_Category_Value
            // 
            this.label_Category_Value.AutoSize = true;
            this.label_Category_Value.Location = new System.Drawing.Point(75, 310);
            this.label_Category_Value.Name = "label_Category_Value";
            this.label_Category_Value.Size = new System.Drawing.Size(110, 13);
            this.label_Category_Value.TabIndex = 36;
            this.label_Category_Value.Text = "label_Category_Value";
            // 
            // label_ItemName_Value
            // 
            this.label_ItemName_Value.AutoSize = true;
            this.label_ItemName_Value.Location = new System.Drawing.Point(513, 260);
            this.label_ItemName_Value.Name = "label_ItemName_Value";
            this.label_ItemName_Value.Size = new System.Drawing.Size(116, 13);
            this.label_ItemName_Value.TabIndex = 37;
            this.label_ItemName_Value.Text = "label_ItemName_Value";
            // 
            // label_Price_Value
            // 
            this.label_Price_Value.AutoSize = true;
            this.label_Price_Value.Location = new System.Drawing.Point(513, 285);
            this.label_Price_Value.Name = "label_Price_Value";
            this.label_Price_Value.Size = new System.Drawing.Size(92, 13);
            this.label_Price_Value.TabIndex = 38;
            this.label_Price_Value.Text = "label_Price_Value";
            // 
            // Check_Stock_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 415);
            this.Controls.Add(this.label_Price_Value);
            this.Controls.Add(this.label_ItemName_Value);
            this.Controls.Add(this.label_Category_Value);
            this.Controls.Add(this.label_Description_Value);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Store_Value);
            this.Controls.Add(this.label_ItemId_Value);
            this.Controls.Add(this.dataGridView_Stock);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_ItemName);
            this.Controls.Add(button_CancelSearch);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_Store);
            this.Controls.Add(this.label_ItemId);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Check_Stock_Form";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Check_Stock_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_ItemId;
        private System.Windows.Forms.Label label_Store;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.DataGridView dataGridView_Stock;
        private System.Windows.Forms.Label label_ItemId_Value;
        private System.Windows.Forms.Label label_Store_Value;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Description_Value;
        private System.Windows.Forms.Label label_Category_Value;
        private System.Windows.Forms.Label label_ItemName_Value;
        private System.Windows.Forms.Label label_Price_Value;
    }
}