using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shapeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(textBox2.Text);
                double ans = 4.0 / 3.0 * Math.PI * r * r * r;
                label1.Text = ans.ToString("0.00");
            }
            catch
            {
                label1.Text = ("0.00");
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(textBox1.Text);
                double H = Convert.ToDouble(textBox3.Text);

                double V = Math.PI * r * r * H / 3.0;
                label2.Text = "Volume = " + V.ToString("0.00");
            }
            catch
            {
                label2.Text = "Volume = ";
            }
            
        }
        
    }
}
