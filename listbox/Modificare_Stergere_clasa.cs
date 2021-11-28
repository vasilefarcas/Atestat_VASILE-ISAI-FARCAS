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
    public partial class Modificare_Stergere_clasa : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|elev.mdf;Integrated Security=True;Connect Timeout=30");
        /* public Modificare_Stergere_clasa()
         {
             InitializeComponent();
             con.Open();
             SqlCommand cmd = new SqlCommand("SELECT * FROM Clase", con);
             SqlDataReader red = cmd.ExecuteReader();
             while (red.Read())
                 comboBox1.Items.Add(red[1].ToString());
             con.Close();
             cmd.Dispose();
         }

         private void button3_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
         {
             con.Open();
             SqlCommand cmd = new SqlCommand("SELECT * FROM Clase WHERE NumeClasa=@nume",con);
             cmd.Parameters.AddWithValue("nume", comboBox1.SelectedItem.ToString());
             SqlDataReader red = cmd.ExecuteReader();
             if(red.Read())
             {
                 textBox1.Text = red[1].ToString();
                 textBox2.Text = red[3].ToString();
                 textBox3.Text = red[2].ToString();
                 label5.Text = red[0].ToString();
             }
             con.Close();
         }

         private void button2_Click(object sender, EventArgs e)
         {
             if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && comboBox1.SelectedIndex.ToString() != "")
                 try
                 {
                     con.Open();
                     SqlCommand cmd = new SqlCommand("DELETE FROM Clase WHERE NumeClasa=@nume", con);
                     cmd.Parameters.AddWithValue("nume", comboBox1.SelectedItem.ToString());
                     int i = cmd.ExecuteNonQuery();
                     if (i == 1)
                     {
                         comboBox1.Items.Clear();
                         comboBox1.ResetText();
                         SqlCommand cmd1 = new SqlCommand("SELECT * FROM Clase", con);
                         SqlDataReader red1 = cmd1.ExecuteReader();
                         while (red1.Read())
                             comboBox1.Items.Add(red1[1].ToString());
                         textBox1.Text = "";
                         textBox2.Text = "";
                         textBox3.Text = "";
                         label5.Text = "";
                         MessageBox.Show("Clasa stearsa cu succes.");
                     }
                     else
                         MessageBox.Show("Clasa nu a fost stearsa.");
                     con.Close();
                     cmd.Dispose();
                 }
                 catch (System.NullReferenceException)
                 {
                     con.Close();
                 }
             else
                 MessageBox.Show("Alege o clasă și apoi apasa butonul de stergere pentru a realiza stergerea.");
         }

         private void button1_Click(object sender, EventArgs e)
         {
             if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && comboBox1.SelectedIndex.ToString() != "")
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("UPDATE Clase SET NumeClasa=@nume, Diriginte=@diriginte, Profil=@profil WHERE Id=@id", con);
                 cmd.Parameters.AddWithValue("id", label5.Text);
                 cmd.Parameters.AddWithValue("nume", textBox1.Text);
                 cmd.Parameters.AddWithValue("profil", textBox2.Text);
                 cmd.Parameters.AddWithValue("diriginte", textBox3.Text);
                 var i = cmd.ExecuteNonQuery();
                 if (i == 1)
                 {
                     MessageBox.Show("Inregistrare actualizată cu succes.");
                     textBox1.Text = "";
                     textBox2.Text = "";
                     textBox3.Text = "";
                     label5.Text = "";
                     comboBox1.Items.Clear();
                     SqlCommand cmd1 = new SqlCommand("SELECT * FROM Clase", con);
                     SqlDataReader red1 = cmd1.ExecuteReader();
                     while (red1.Read())
                         comboBox1.Items.Add(red1[1].ToString());
                     comboBox1.ResetText();
                 }
                 else
                     MessageBox.Show("Inregistrarea nu a fost actualizată.");
                 con.Close();
             }
             else
                 MessageBox.Show("Alege o clasă și completează toate câmpurile.");

             }
        */
        public Modificare_Stergere_clasa()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clase", con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
                comboBox1.Items.Add(red[1].ToString());
            con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Profesori",con);
            SqlDataReader red1 = cmd1.ExecuteReader();
            while (red1.Read())
                comboBox2.Items.Add(red1[1].ToString());
            con.Close();
            cmd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clase WHERE NumeClasa=@nume", con);
            cmd.Parameters.AddWithValue("nume", comboBox1.SelectedItem.ToString());
            SqlDataReader red = cmd.ExecuteReader();
            if (red.Read())
            {
                textBox1.Text = red[1].ToString();
                textBox2.Text = red[3].ToString();
                comboBox1.SelectedItem = red[1].ToString();
                comboBox2.SelectedItem = red[2].ToString();
                label6.Text = red[0].ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && comboBox1.SelectedIndex.ToString().Length > 0 && label6.Text.Length > 0) 
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Clase WHERE NumeClasa=@nume", con);
                    cmd.Parameters.AddWithValue("nume", comboBox1.SelectedItem.ToString());
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        comboBox1.Items.Clear();
                        comboBox1.ResetText();
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM Clase", con);
                        SqlDataReader red1 = cmd1.ExecuteReader();
                        while (red1.Read())
                            comboBox1.Items.Add(red1[1].ToString());
                        textBox1.Text = "";
                        textBox2.Text = "";
                        comboBox1.ResetText();
                        comboBox2.ResetText();
                        label5.Text = "";
                        MessageBox.Show("Clasa stearsa cu succes.");
                    }
                    else
                        MessageBox.Show("Clasa nu a fost stearsa.");
                    con.Close();
                    cmd.Dispose();
                }
                catch (System.NullReferenceException)
                {
                    con.Close();
                }
            }
            else
                MessageBox.Show("Alege o clasă și apoi apasa butonul de stergere pentru a realiza stergerea.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && comboBox1.SelectedIndex.ToString().Length > 0 && label5.Text.Length>0)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Clase SET NumeClasa=@nume, Diriginte=@diriginte, Profil=@profil WHERE Id=@id", con);
                    cmd.Parameters.AddWithValue("id", label6.Text.ToString());
                    cmd.Parameters.AddWithValue("nume", textBox1.Text);
                    cmd.Parameters.AddWithValue("profil", textBox2.Text);
                    cmd.Parameters.AddWithValue("diriginte", comboBox2.SelectedItem.ToString());
                    var i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Inregistrare actualizată cu succes.");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        comboBox1.ResetText();
                        label6.Text = "";
                        comboBox2.ResetText();
                        comboBox1.Items.Clear();
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM Clase", con);
                        SqlDataReader red1 = cmd1.ExecuteReader();
                        while (red1.Read())
                            comboBox1.Items.Add(red1[1].ToString());
                        comboBox1.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Inregistrarea nu a fost actualizată.");
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Alege o clasă și completează toate câmpurile.");
                    con.Close();
                }
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Alege o clasă și completează toate câmpurile.");
                con.Close();
            }

        }

        private void Modificare_Stergere_clasa_Load(object sender, EventArgs e)
        {

        }
    }
}
