using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1204017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Kelas = "";
            String Jadwal = "";

            if (rbJadwal1.Checked)
            {
                Jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if(rbJadwal2.Checked)
            {
                Jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }else if (rbJadwal3.Checked)
            {
                Jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }else if (rbJadwal4.Checked)
            {
                Jadwal = "Minggu 13.00 -  17.00";
            }

            //checkBox

            if (cbBiola.Checked)
            {
                Kelas += "Biola";
            }
            if (cbDrum.Checked)
            {
                Kelas += "Drum";
            }
            if (cbGitar.Checked)
            {
                Kelas += "Gitar";
            }
            if (cbKomposer.Checked)
            {
                Kelas += "Komposer";
            }
            if (cbKonduktor.Checked)
            {
                Kelas += "Konduktor";
            }
            if (cbPiano.Checked)
            {
                Kelas += "Piano";
            }
            if (cbSaxophone.Checked)
            {
                Kelas += "saxophone";
            }
            if (cbVokal.Checked)
            {
                Kelas += "Vokal";
            }
            if (Kelas == "")
            {
                MessageBox.Show("Harus Memilih salah satu dari pilihan kelas ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //messagebox
            MessageBox.Show("Nama : " + nama.Text + "\nTanggal Lahir : " + dtTglLahir.Text + "\nJenis Kelamin : " + cbJK.Text + "\nPilihan Kelas : " + Kelas + "\nPilihan Jadwal : " + Jadwal + "\nInformasi Pendaftaran");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

       
    }

