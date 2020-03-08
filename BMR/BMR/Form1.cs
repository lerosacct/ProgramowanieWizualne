using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mass;
            double height;
            double age;

            Double.TryParse(m.Text, out mass);
            Double.TryParse(w.Text, out height);
            Double.TryParse(a.Text, out age);

            {
                if (f.Checked)
                {
                    result.Text = Convert.ToString(mass * 99.9 + height * 6.25 - 4.94 * age - 161);
                }else{
                    result.Text = Convert.ToString(mass * 99.9 + height * 6.25 - 4.94 * age + 5);
                }
            }
            
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
