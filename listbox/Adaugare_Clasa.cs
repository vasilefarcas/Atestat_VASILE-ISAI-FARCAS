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
    public partial class Adaugare_Clasa : Form
    {

        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|elev.mdf;Integrated Security=True;Connect Timeout=30");
        public Adaugare_Clasa()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Profesori",con);
            SqlDataReader red = cmd.ExecuteReader();
            while(red.Read())
            {
                comboBox1.Items.Add(red[1].ToString());
            }
            con.Close();
            cmd.Dispose();
            red.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength>0 && textBox2.TextLength>0 && comboBox1.SelectedIndex.ToString()!="")
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Clase(NumeClasa, Diriginte, Profil) VALUES(@nume, @diriginte, @profil)", con);
                cmd.Parameters.AddWithValue("nume", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("diriginte", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("profil", textBox2.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Clasa a fost adaugata cu succes!");
                    comboBox1.ResetText();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                    MessageBox.Show("Clasa nu a fost adaugata.");
                con.Close();
            }
            catch (System.NullReferenceException)
            {
                con.Close();
                MessageBox.Show("Asigurate ca ai completat toate campurile.");
            }
            else
                MessageBox.Show("Asigurate ca ai completat toate campurile.");
        }
    }
}
