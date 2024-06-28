using LICENTA_VASILE_ISAI_FARCAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LICENTA_VASILE_ISAI_FARCAS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            panel10.Visible = false;
            panel11.Visible = false;
            panel26.Visible = false;
           
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Date_Licenta formBegginingInformation = new Date_Licenta();
            formBegginingInformation.Show();
        }

        private void pictureBox_Instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/vasilefarcass/");
        }

        private void pictureBox_Facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/vasilefarcass/");
        }
        #region Show/Unshow Options
        private void button_Stock_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            panel11.Visible = false;
            panel26.Visible = false;
        }
        private void button_Shop_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel10.Visible = false;
            panel26.Visible = false;
        }

        private void button_Employee_Click(object sender, EventArgs e)
        {
            panel26.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
        }
        #endregion
        private void panel26_MouseEnter(object sender, EventArgs e)
        {
            panel26.Visible = true;
        }

        private void panel26_MouseLeave(object sender, EventArgs e)
        {
            panel26.Visible = false;
        }

        private void Add_Item_Form_Click(object sender, EventArgs e)
        {
            Add_Item_Form f1 = new Add_Item_Form();
            f1.Show();
        }

        private void button_Modify_Delete_Item_Click(object sender, EventArgs e)
        {
            Check_Stock_Form f1 = new Check_Stock_Form();
            f1.Show();
        }

        private void button_Add_Shop_Click(object sender, EventArgs e)
        {
            Store_Add_Form f1 = new Store_Add_Form();
            f1.Show();
        }

        private void button_Modify_Delete_Shop_Click(object sender, EventArgs e)
        {
            Modify_Delete_Shop_Form f1 = new Modify_Delete_Shop_Form();
            f1.Show();
        }

        private void button_Add_Employee_Click(object sender, EventArgs e)
        {
            Add_Employee_Form f1 = new Add_Employee_Form();
            f1.Show();
        }

        private void button_Modify_Delete_Employee_Click(object sender, EventArgs e)
        {
            Modify_Delete_Employee_Form f1 = new Modify_Delete_Employee_Form();
            f1.Show();
        }

        private void button_ModifyStock_Click(object sender, EventArgs e)
        {
            Check_Stock_Form f1 = new Check_Stock_Form();
            f1.Show();
        }

        private void button_EditItem_Click(object sender, EventArgs e)
        {
            Item_Modify_Delete f1 = new Item_Modify_Delete();
            f1.Show();
        }
    }
}
