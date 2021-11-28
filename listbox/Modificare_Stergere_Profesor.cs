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
    public partial class Modificare_Stergere_Profesor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|elev.mdf;Integrated Security=True;Connect Timeout=30");
        public Modificare_Stergere_Profesor()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Profesori",con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                comboBox1.Items.Add(red[1].ToString());
            }
            cmd.Dispose();
            red.Dispose();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && comboBox1.SelectedIndex.ToString() != "")
            { 
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Profesori SET Nume=@nume, Materie=@materie WHERE Id=@id", con);
                    cmd.Parameters.AddWithValue("id", label5.Text);
                    cmd.Parameters.AddWithValue("nume", textBox1.Text);
                    cmd.Parameters.AddWithValue("materie", textBox2.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Datele profesorului au fost actualizate cu succes.");
                        label5.Text = "";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        comboBox1.ResetText();
                        comboBox1.Items.Clear();
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM Profesori", con);
                        SqlDataReader red1 = cmd1.ExecuteReader();
                        while (red1.Read())
                        {
                            comboBox1.Items.Add(red1[1].ToString());
                        }
                        cmd1.Dispose();
                        red1.Dispose();
                    }
                    else
                        MessageBox.Show("Datele profesorului nu au fost actualizate.");
                    cmd.Dispose();
                    con.Close();
                }
                catch (System.InvalidOperationException)
                {
                    con.Close();
                    MessageBox.Show("Selectează un profesor și completează toate câmpurile.");
                }
            }
            else
                MessageBox.Show("Selectează profesorul dorit și nu lăsa câmpurile necompletate.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Profesori WHERE Nume=@nume", con);
                cmd.Parameters.AddWithValue("nume", comboBox1.SelectedItem.ToString());
                SqlDataReader red = cmd.ExecuteReader();
                if (red.Read())
                {
                    label5.Text = red[0].ToString();
                    textBox1.Text = red[1].ToString();
                    textBox2.Text = red[2].ToString();
                }
                con.Close();
                cmd.Dispose();
            }
            catch (System.InvalidOperationException)
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.ToString() != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Profesori WHERE Id=@id", con);
                    cmd.Parameters.AddWithValue("id", label5.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Profesorul selectat a fost sters cu succes.");

                        label5.Text = "";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        comboBox1.ResetText();
                        comboBox1.Items.Clear();
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM Profesori", con);
                        SqlDataReader red1 = cmd1.ExecuteReader();
                        while (red1.Read())
                        {
                            comboBox1.Items.Add(red1[1].ToString());
                        }
                        cmd1.Dispose();
                        red1.Dispose();

                    }
                    else   
                        MessageBox.Show("                                     Profesorul nu a fost sters.\n Verificâ dacă ai selectat un profesor și ai completat toate câmpurile.");
                } 
                catch (System.InvalidOperationException)
                {
                    label5.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.ResetText();
                    comboBox1.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM Profesori", con);
                    SqlDataReader red1 = cmd1.ExecuteReader();
                    while (red1.Read())
                    {
                        comboBox1.Items.Add(red1[1].ToString());
                    }
                    cmd1.Dispose();
                    red1.Dispose();
                }
            }
            else
                MessageBox.Show("Selecteaza profesorul pe care doresti sa il stergi.");
        }
    }
}
