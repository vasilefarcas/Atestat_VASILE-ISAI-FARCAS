using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class MeniuPrincipal : Form
    {
        public MeniuPrincipal()
        {
            InitializeComponent();
            panel10.Visible = false;
            panel11.Visible = false;
            panel26.Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Date_Atestat f1 = new Date_Atestat();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificare_Stergere_Elev f1 = new Modificare_Stergere_Elev();
            f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/vasilefarcass/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/vasilefarcass/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            panel11.Visible = false;
            panel26.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel10.Visible = false;
            panel26.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel26.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
        }

        private void panel26_MouseEnter(object sender, EventArgs e)
        {
            panel26.Visible = true;
        }

        private void panel26_MouseLeave(object sender, EventArgs e)
        {
            panel26.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inregistrare_elev f1 = new Inregistrare_elev();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Modificare_Stergere_Vizualizare_Cautare_Elevi f1 = new Modificare_Stergere_Vizualizare_Cautare_Elevi();
            f1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Adaugare_Profesor f1 = new Adaugare_Profesor();
            f1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Modificare_Stergere_Profesor f1 = new Modificare_Stergere_Profesor();
            f1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Adaugare_Clasa f1 = new Adaugare_Clasa();
            f1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Modificare_Stergere_clasa f1 = new Modificare_Stergere_clasa();
            f1.Show();
        }
    }
}
