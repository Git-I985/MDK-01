using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25._10z18
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t1 = Convert.ToInt32(textBox1.Text);
            int t2 = Convert.ToInt32(textBox2.Text);
            int summa = 0;

            summa = t1 * 10 + t2 * 20;

            if (comboBox1.SelectedIndex == 0)
            {
                summa += 100;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                summa += 200;
            }

            if (checkBox1.Checked)
            {
                summa += 100;
            } 
            if (checkBox2.Checked)
            {
                summa += 200;
            }
            if (checkBox3.Checked)
            {
                summa += 300;
            }


            textBox3.Text = Convert.ToString(summa);
        }
    }
}
