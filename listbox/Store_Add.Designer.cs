
namespace LICENTA_VASILE_ISAI_FARCAS
{
    partial class Store_Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store_Add_Form));
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(8, 6);
            this.label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(264, 24);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Insert the data of the new store";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(17, 54);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(48, 18);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Chartreuse;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(62, 132);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(195, 34);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Inregistrare";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Location = new System.Drawing.Point(105, 170);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(96, 26);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Iesire";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.Location = new System.Drawing.Point(17, 94);
            this.label_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(62, 18);
            this.label_Address.TabIndex = 4;
            this.label_Address.Text = "Address";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(91, 54);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(166, 20);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(91, 94);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(139, 20);
            this.textBox_Address.TabIndex = 6;
            // 
            // Store_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 203);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Store_Add_Form";
            this.Text = "Add Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Address;
    }
}