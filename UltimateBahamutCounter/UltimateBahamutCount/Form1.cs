using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateBahamutCounter
{
    public partial class Form1 : Form
    {
        int total = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void totalTextColorChange()
        {
            if (total >= 50)
            {
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("1 Cost");
            total += 1;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("2 Cost");
            total += 2;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("3 Cost");
            total += 3;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("4 Cost");
            total += 4;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("5 Cost");
            total += 5;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("6 Cost");
            total += 6;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("7 Cost");
            total += 7;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("8 Cost");
            total += 8;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("9 Cost");
            total += 9;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("10 Cost");
            total += 10;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.SelectedItem.ToString();

                if (listBox1.SelectedItem.Equals("1 Cost"))
                {
                    total -= 1;
                    label4.Text = Convert.ToString(total);
                }
                else if (listBox1.SelectedItem.Equals("2 Cost"))
                {
                    total -= 2;
                    label4.Text = Convert.ToString(total);
                }
                else if (listBox1.SelectedItem.Equals("3 Cost"))
                {
                    total -= 3;
                    label4.Text = Convert.ToString(total);
                }
                else if (listBox1.SelectedItem.Equals("4 Cost"))
                {
                    total -= 4;
                    label4.Text = Convert.ToString(total);
                }
                else if (listBox1.SelectedItem.Equals("5 Cost"))
                {
                    total -= 5;
                    label4.Text = Convert.ToString(total);
                }
                else if (listBox1.SelectedItem.Equals("6 Cost"))
                {
                    total -= 6;
                    label4.Text = Convert.ToString(total);
                }
                else if (listBox1.SelectedItem.Equals("7 Cost"))
                {
                    total -= 7;
                    label4.Text = Convert.ToString(total);
                }
                else if (listBox1.SelectedItem.Equals("8 Cost"))
                {
                    total -= 8;
                    label4.Text = Convert.ToString(total);
                }
                else if (listBox1.SelectedItem.Equals("9 Cost"))
                {
                    total -= 9;
                    label4.Text = Convert.ToString(total);
                }
                else if (listBox1.SelectedItem.Equals("10 Cost"))
                {
                    total -= 10;
                    label4.Text = Convert.ToString(total);
                }

                Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                totalTextColorChange();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            total = 0;
            label4.Text = Convert.ToString(total);
            totalTextColorChange();
        }
    }
}
