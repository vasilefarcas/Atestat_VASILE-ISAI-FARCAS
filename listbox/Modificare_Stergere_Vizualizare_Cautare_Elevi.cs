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
    public partial class Modificare_Stergere_Vizualizare_Cautare_Elevi : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|elev.mdf;Integrated Security=True;Connect Timeout=30");
        public Modificare_Stergere_Vizualizare_Cautare_Elevi()
        {
            InitializeComponent();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Elevi", con);
                SqlDataReader red = cmd.ExecuteReader();

                string var;
                int i;

                while (red.Read())
                {

                    var = red[0].ToString() + "             ";
                    var = var + red[1].ToString();
                    for (i = 1; i <= 18 - red[1].ToString().Length; i += 2)
                        var = var + "  ";
                    var = var + red[2].ToString();
                    for (i = 1; i <= 28 - red[2].ToString().Length; i += 2)
                        var = var + "  ";
                    var = var + red[5].ToString();
                    for (i = 1; i <= 30 - red[5].ToString().Length; i += 2)
                        var = var + "  ";
                    var = var + red[4].ToString();
                    for (i = 1; i <= 43 - red[4].ToString().Length; i += 2)
                        var = var + "  ";
                    
                    if(red[6].ToString().Length==20)
                    var = var + red[6].ToString().Remove(8, 12);
                    else if (red[6].ToString().Length == 21)
                        var = var + red[6].ToString().Remove(9, 12);
                    else if (red[6].ToString().Length == 22)
                        var = var + red[6].ToString().Remove(10, 12);
                    listBox1.Items.Add(var);
                    var = "";
                }
                con.Close();
                cmd.Dispose();
            }
            catch(System.ArgumentOutOfRangeException)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd1 = new SqlCommand(@"SELECT * FROM Clase", con);
            SqlDataReader red1 = cmd1.ExecuteReader();
            while (red1.Read())
                comboBox1.Items.Add(red1[1].ToString());


            con.Close();
            red1.Dispose();
            cmd1.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Elevi WHERE NrMatricol=@nr", con);
            cmd.Parameters.AddWithValue("nr", textBox1.Text);
            SqlDataReader red = cmd.ExecuteReader();
            if (red.Read())
            {
                textBox2.ResetText();
                textBox3.ResetText();
                textBox4.ResetText();
                textBox5.ResetText();
                textBox6.ResetText();
                comboBox1.ResetText();
                label15.Text = "";

                string var;
                int i;
                listBox1.Items.Clear();
                var = red[0].ToString() + "             ";
                var = var + red[1].ToString();
                for (i = 1; i <= 18 - red[1].ToString().Length; i += 2)
                    var = var + "  ";
                var = var + red[2].ToString();
                for (i = 1; i <= 28 - red[2].ToString().Length; i += 2)
                    var = var + "  ";
                var = var + red[5].ToString();
                for (i = 1; i <= 30 - red[5].ToString().Length; i += 2)
                    var = var + "  ";
                var = var + red[4].ToString();
                for (i = 1; i <= 43 - red[4].ToString().Length; i += 2)
                    var = var + "  ";
                if (red[6].ToString().Length == 20)
                    var = var + red[6].ToString().Remove(8, 12);
                else if (red[6].ToString().Length == 21)
                    var = var + red[6].ToString().Remove(9, 12);
                else if (red[6].ToString().Length == 22)
                    var = var + red[6].ToString().Remove(10, 12);
                listBox1.Items.Add(var);
                var = "";
                listBox1.Items.Add(var);
            }
            else
                MessageBox.Show("Elevul cu numarul matricol introdus nu exista. Verifica datele introdus!");
            red.Dispose();
            con.Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Elevi WHERE NrMatricol=@nr", con);
                string var = listBox1.SelectedItem.ToString();
                int i = var.Length;
                var = var.Remove(7, var.Length - 7);
                cmd.Parameters.AddWithValue("nr", var);
                SqlDataReader red = cmd.ExecuteReader();
                red.Read();
                label15.Text = red[0].ToString();
                textBox2.Text = red[1].ToString();
                textBox3.Text = red[2].ToString();
                comboBox1.SelectedItem = red[3].ToString();
                textBox4.Text = red[4].ToString();
                textBox5.Text = red[5].ToString();
                if (red[6].ToString().Length == 20)
                    textBox6.Text = red[6].ToString().Remove(8, 12);
                else if (red[6].ToString().Length == 21)
                    textBox6.Text =  red[6].ToString().Remove(9, 12);
                else if (red[6].ToString().Length == 22)
                    textBox6.Text =  red[6].ToString().Remove(10, 12);
                con.Close();
                red.Dispose();
            }
            catch (System.NullReferenceException)
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Elevi", con);
                SqlDataReader red = cmd.ExecuteReader();
                string var;
                int i;
                while (red.Read())
                {
                    var = red[0].ToString() + "             ";
                    var = var + red[1].ToString();
                    for (i = 1; i <= 18 - red[1].ToString().Length; i += 2)
                        var = var + "  ";
                    var = var + red[2].ToString();
                    for (i = 1; i <= 28 - red[2].ToString().Length; i += 2)
                        var = var + "  ";
                    var = var + red[5].ToString();
                    for (i = 1; i <= 30 - red[5].ToString().Length; i += 2)
                        var = var + "  ";
                    var = var + red[4].ToString();
                    for (i = 1; i <= 43 - red[4].ToString().Length; i += 2)
                        var = var + "  ";
                    if (red[6].ToString().Length == 20)
                        var = var + red[6].ToString().Remove(8, 12);
                    else if (red[6].ToString().Length == 21)
                        var = var + red[6].ToString().Remove(9, 12);
                    else if (red[6].ToString().Length == 22)
                        var = var + red[6].ToString().Remove(10, 12);

                    listBox1.Items.Add(var);
                    var = "";
                }
                textBox1.Text = "";
                textBox2.ResetText();
                textBox3.ResetText();
                textBox4.ResetText();
                textBox5.ResetText();
                textBox6.ResetText();
                comboBox1.ResetText();
                label15.Text = "";
                con.Close();
                red.Dispose();
            }
            catch(System.InvalidOperationException)
            {
                con.Close();
            }
        }
        
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Elevi WHERE NrMatricol=@nr", con);
                string var = listBox1.SelectedItem.ToString();
                int i = var.Length;
                var = var.Remove(7, var.Length - 7);
                cmd.Parameters.AddWithValue("nr", var);
                int m = cmd.ExecuteNonQuery();
                if (m == 1)
                {
                    MessageBox.Show("Inregistrare stearsa cu succes!");
                    listBox1.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand(@"SELECT * FROM Elevi", con);
                    SqlDataReader red1 = cmd1.ExecuteReader();

                    textBox1.Text = "";
                    label15.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    comboBox1.ResetText();

                    while (red1.Read())
                    {

                        var = red1[0].ToString() + "             ";
                        var = var + red1[1].ToString();
                        for (i = 1; i <= 18 - red1[1].ToString().Length; i += 2)
                            var = var + "  ";
                        var = var + red1[2].ToString();
                        for (i = 1; i <= 28 - red1[2].ToString().Length; i += 2)
                            var = var + "  ";
                        var = var + red1[5].ToString();
                        for (i = 1; i <= 30 - red1[5].ToString().Length; i += 2)
                            var = var + "  ";
                        var = var + red1[4].ToString();
                        for (i = 1; i <= 43 - red1[4].ToString().Length; i += 2)
                            var = var + "  ";
                        if (red1[6].ToString().Length == 20)
                            var = var + red1[6].ToString().Remove(8, 12);
                        else if (red1[6].ToString().Length == 21)
                            var = var + red1[6].ToString().Remove(9, 12);
                        else if (red1[6].ToString().Length == 22)
                            var = var + red1[6].ToString().Remove(10, 12);
                        listBox1.Items.Add(var);
                        var = "";
                    }
                    con.Close();
                    cmd.Dispose();
                }
                else MessageBox.Show("Inregistrarea nu a fost stearsa :(");
                

                con.Close();
                cmd.Dispose();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Inainte de a incerca sa stergi vreo inregistrare selecteaza prin dublu click elevul pe care doresti sa il stergi.");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0 && textBox5.TextLength > 0 && textBox6.TextLength > 0)
            {     
                try
                { 
                    comboBox1.ResetText();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Elevi SET Nume=@nume, Prenume=@prenume, Clasa=@clasa, Email=@email, Adresa=@adresa, DataNasterii=@data WHERE NrMatricol=@id", con);
                    cmd.Parameters.AddWithValue("id", label15.Text);
                    cmd.Parameters.AddWithValue("nume", textBox2.Text);
                    cmd.Parameters.AddWithValue("prenume", textBox3.Text);
                    cmd.Parameters.AddWithValue("clasa", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("email", textBox4.Text);
                    cmd.Parameters.AddWithValue("adresa", textBox5.Text);
                    cmd.Parameters.AddWithValue("data", textBox6.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r == 1)
                    {
                        MessageBox.Show("Datele elevului au fost actualizate cu succes!");
                        textBox2.ResetText();
                        textBox3.ResetText();
                        textBox4.ResetText();
                        textBox5.ResetText();
                        textBox6.ResetText();
                        comboBox1.ResetText();
                        label15.Text = "";
                        listBox1.Items.Clear();
                        SqlCommand cmd1 = new SqlCommand(@"SELECT * FROM Elevi", con);
                        SqlDataReader red1 = cmd1.ExecuteReader();
                        string var;
                        int i;
                        while (red1.Read())
                        {
                            var = red1[0].ToString() + "             ";
                            var = var + red1[1].ToString();
                            for (i = 1; i <= 18 - red1[1].ToString().Length; i += 2)
                                var = var + "  ";
                            var = var + red1[2].ToString();
                            for (i = 1; i <= 28 - red1[2].ToString().Length; i += 2)
                                var = var + "  ";
                            var = var + red1[5].ToString();
                            for (i = 1; i <= 30 - red1[5].ToString().Length; i += 2)
                                var = var + "  ";
                            var = var + red1[4].ToString();
                            for (i = 1; i <= 43 - red1[4].ToString().Length; i += 2)
                                var = var + "  ";
                            if (red1[6].ToString().Length == 20)
                                var = var + red1[6].ToString().Remove(8, 12);
                            else if (red1[6].ToString().Length == 21)
                                var = var + red1[6].ToString().Remove(9, 12);
                            else if (red1[6].ToString().Length == 22)
                                var = var + red1[6].ToString().Remove(10, 12);
                            listBox1.Items.Add(var);
                            var = "";
                        }
                    }
                    con.Close();
                }
                    catch (System.NullReferenceException)
                    {
                        MessageBox.Show("Selecteaza un elev si completeaza toate campurile.");
                        con.Close();
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        con.Close();
                    }
            }
                else
                    MessageBox.Show("Selecteaza un elev si completeaza toate campurile.");
        }
    }
    
}
