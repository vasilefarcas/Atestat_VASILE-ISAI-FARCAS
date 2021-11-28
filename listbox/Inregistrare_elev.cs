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
    public partial class Inregistrare_elev : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|elev.mdf;Integrated Security=True;Connect Timeout=30");
        public Inregistrare_elev()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clase",con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
                comboBox1.Items.Add(red[1].ToString());
            con.Close();
            red.Dispose();
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text.Length > 0 && textBox1.Text.Length > 0 && textBox1.Text.Length > 0 && comboBox1.SelectedIndex.ToString().Length > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Elevi(Nume, Prenume, Clasa, Email, Adresa, DataNasterii) VALUES(@n,@p,@c,@e,@a,@d)", con);

                    cmd.Parameters.AddWithValue("n", textBox1.Text);
                    cmd.Parameters.AddWithValue("p", textBox2.Text);
                    cmd.Parameters.AddWithValue("c", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("e", textBox4.Text);
                    cmd.Parameters.AddWithValue("a", textBox3.Text);
                    cmd.Parameters.AddWithValue("d", monthCalendar1.SelectionRange.Start.ToString());
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Elevul a fost inregistrat cu succes!");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        comboBox1.ResetText();
                        monthCalendar1.ResetText();
                    }
                    else
                        MessageBox.Show("Elevul nu a fost inregistrat.");
                    cmd.Dispose();
                    con.Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    con.Close();
                    MessageBox.Show("Completeaza toate campurile.");
                }
            }
            else
                MessageBox.Show("Completeaza toate campurile.");
        }
    }
}
