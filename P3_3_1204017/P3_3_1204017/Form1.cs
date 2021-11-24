using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_3_1204017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbMouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tslKetGambar.Text = "COCOK INI ADALAH GAMBAR MOUSE";
            }else
            {
                tslKetGambar.Text = "TIDAK COCOK! ANDA MEMILIH GAMBAR YANG SALAH\n INI ADALAH GAMBAR MOUSE";
            }
        }

        private void tsbMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tslKetGambar.Text = "COCOK INI ADALAH GAMBAR MOUSE";
            }
            else
            {
                tslKetGambar.Text = "TIDAK COCOK! ANDA MEMILIH GAMBAR YANG SALAH\n INI ADALAH GAMBAR MOUSE";
            }
        }

        private void tsbPrinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tslKetGambar.Text = "COCOK INI ADALAH GAMBAR MOUSE";
            }
            else
            {
                tslKetGambar.Text = "TIDAK COCOK! ANDA MEMILIH GAMBAR YANG SALAH\n INI ADALAH GAMBAR MOUSE";
            }
        }

        private void tsbKeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tslKetGambar.Text = "COCOK INI ADALAH GAMBAR MOUSE";
            }
            else
            {
                tslKetGambar.Text = "TIDAK COCOK! ANDA MEMILIH GAMBAR YANG SALAH\n INI ADALAH GAMBAR MOUSE";
            }
        }

        private void tsGambar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (rbScanner.Checked == true)
            {
                tslKetGambar.Text = "COCOK INI ADALAH GAMBAR MOUSE";
            }
            else
            {
                tslKetGambar.Text = "TIDAK COCOK! ANDA MEMILIH GAMBAR YANG SALAH\n INI ADALAH GAMBAR MOUSE";
            }
        }
    }
}
