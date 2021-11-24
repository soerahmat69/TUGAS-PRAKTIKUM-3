using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_1_1204017
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void HelloButton_Click(object sender, EventArgs e)
        {
            OutpuLabel.Text = "Hello, World";
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
