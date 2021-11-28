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

namespace listbox
{
    public partial class Adaugare_Profesor : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|elev.mdf;Integrated Security=True;Connect Timeout=30");

        public Adaugare_Profesor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ok;
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0)
                ok = 1;
            else
                ok = 0;
            if (ok == 1)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Profesori(Nume, Materie) VALUES(@nume, @materie)", con);
                cmd.Parameters.AddWithValue("nume", textBox1.Text);
                cmd.Parameters.AddWithValue("materie", textBox2.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Profesorul a fost inregistrat cu succes!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                    MessageBox.Show("Ceva nu a mers bine. Verifica datele introduse");
                con.Close();
                cmd.Dispose();
            }
            else
                MessageBox.Show("Asigura-te ca ai completat toate campurile.");
        }
    }
}
