using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp_string = pesel.Text;
            int test_passed = 0;

            if ((Convert.ToInt32(temp_string[2]) - 48) < 2)
            {
                progressBar1.Value = test_passed;
                test_passed++;
                if ((Convert.ToInt32(temp_string[4]) - 48) < 3)
                {
                    progressBar1.Value = test_passed;
                    test_passed++;
                    if (temp_string.Length == 11)
                    {
                        progressBar1.Value = test_passed;
                        test_passed++;
                        int calc = (1 * (Convert.ToInt32(temp_string[0]) - 48)) +
                                (3 * (Convert.ToInt32(temp_string[1]) - 48)) +
                                (7 * (Convert.ToInt32(temp_string[2]) - 48)) +
                                (9 * (Convert.ToInt32(temp_string[3]) - 48)) +
                                (1 * (Convert.ToInt32(temp_string[4]) - 48)) +
                                (3 * (Convert.ToInt32(temp_string[5]) - 48)) +
                                (7 * (Convert.ToInt32(temp_string[6]) - 48)) +
                                (9 * (Convert.ToInt32(temp_string[7]) - 48)) +
                                (1 * (Convert.ToInt32(temp_string[8]) - 48)) +
                                (3 * (Convert.ToInt32(temp_string[9]) - 48));

                        int lastDigit = 10 - calc % 10;
                        if (Convert.ToInt32(temp_string[10])-48 == lastDigit)
                        {
                            progressBar1.Value = test_passed;
                            test_passed++;
                        }
                    }
                }
            }
            progressBar1.Value = test_passed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
