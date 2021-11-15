using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18._10zadashi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            { textBox1.Text = "ЭСиКС"; textBox2.Text = "3"; textBox3.Text = "Информационные системы и прог-е"; }
            else if (comboBox1.SelectedIndex == 1)
            { textBox1.Text = "ЭСиКС"; textBox2.Text = "2"; textBox3.Text = "Компьютерные сети"; }
            else
            { textBox1.Text = "ПХК"; textBox2.Text = "1"; textBox3.Text = "ПХК"; }
        }
    }
}
