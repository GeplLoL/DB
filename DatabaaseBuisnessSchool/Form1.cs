using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaaseBuisnessSchool
{
    public partial class Form1 : Form
    {
        int Id = 0;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();
            NaitaKategooria();
        }
        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Toode.Id, Toode.Toodenimetus, Toode.Kogus, Toode.Hind, Toode.Pilt, Kategooriad.Kategooria_nimetus FROM Toode INNER JOIN Kategooriad ON Toode.Kategooriad=Kategooriad.Id", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource= dt_toode;
            DataGridViewComboBoxColumn dgvcb = new DataGridViewComboBoxColumn();
            foreach (DataRow item in dt_toode.Rows)
            {
                if (!dgvcb.Items.Contains(item["Kategooria_nimetus"]))
                    dgvcb.Items.Add(item["Kategooria_nimetus"]);
            }
            foreach (DataRow item in dt_toode.Rows)
            {
                dt_toode.Rows.Add(item["Toodenimetus"], item["Kogus"], item["Hind"], item["Pilt"]);
            }
            dataGridView1.DataSource = dt_toode;
            dataGridView1.Columns.Add(dgvcb);
            connect.Close();
        }
        public void NaitaKategooria()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooriad", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows)
            {
                Kat_Box.Items.Add(item["Kategooria_nimetus"]);
            }
            connect.Close();
        }

        private void Hind_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Open();
            adapter_toode = new SqlDataAdapter("SELECT Hind FROM Toode", connect);
            DataTable dt_kat = new DataTable();
            adapter_toode.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows)
            {
                Hind_Box.Items.Add(item["Hind"]);
            }
            connect.Close();
        }
        private void LisaLisa_Katbutt_Click(object sender, EventArgs e)
        {
            if (Toode_Box.Text.Trim() != string.Empty && Kogus_Box.Text.Trim() != string.Empty && Hind_Box.Text.Trim() != string.Empty && Kat_Box.SelectedItem != null)
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("INSERT INTO Toode (Toodenimetus, Kogus, Hind, Pilt, Kategooriad) VALUES (@toode, @kogus, @hind, @pilt, @kat)", connect);
                    command.Parameters.AddWithValue("@kat", Kat_Box.Text);
                    command.ExecuteNonQuery();
                    int Id = Convert.ToInt32(command.ExecuteScalar());
                    command.Parameters.AddWithValue("@toode", Toode_Box.Text);
                    command.Parameters.AddWithValue("@kogus", Kogus_Box.Text);
                    command.Parameters.AddWithValue("@hind", Hind_Box.Text);
                    command.Parameters.AddWithValue("@pilt", Toode_Box.Text + ".jpg");
                    command.Parameters.AddWithValue("@kat", Id);//Id?

                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmebaas");
            }
        }
        private void Kustuta_Katbutt_Click(object sender, EventArgs e)
        {
            if (Kat_Box.SelectedItem !=null)
            {
                string val_kat = Kat_Box.SelectedItem.ToString();
                command = new SqlCommand("DELETE FROM Kategooriad where Kategooria_nimetus=@kat", connect);
                connect.Open();
                command.Parameters.AddWithValue("@kat", val_kat);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaKategooria();
            }
        }

        private void Uuenda_Katbutt_Click(object sender, EventArgs e)
        {
            NaitaKategooria();
        }
        string kat;
        SaveFileDialog save;
        OpenFileDialog open;

        private void Otsi_Katbutt_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\Pictures";
            open.Multiselect = true;
            open.Filter = "Images Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            //FileInfo open_info = new FileInfo(@"C:\Users\opilane\Pictures\" + open.FileName);
            if (open.ShowDialog()==DialogResult.OK && Toode_Box.Text!=null)
            {
                save= new SaveFileDialog();
                save.InitialDirectory=Path.GetFullPath(@"..\..\Images");
                save.FileName=Toode_Box.Text+Path.GetExtension(open.FileName);
                save.Filter = "Images" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);
                if (save.ShowDialog()==DialogResult.OK && Toode_Box.Text != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    pictureBox1.Image=Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            Toode_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogus_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hind_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(@"..\..\Images"+ dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Pilt puudub");
            }
            Kat_Box.SelectedItem= dataGridView1.Rows[e.RowIndex].Cells[5].Value;
        }

        private void Lisa_Katbutt_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("INSERT INTO Kategooriad (Kategooria_nimetus) VALUES (@kat)", connect);
            connect.Open();
            command.Parameters.AddWithValue("@kat", Kat_Box.Text);
            command.ExecuteNonQuery();
            connect.Close();
            Kat_Box.Items.Clear();
            NaitaKategooria();
        }
    }
}
