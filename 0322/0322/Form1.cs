using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0322
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] st1 = new string[] { "+", "-", "*", "/" };
            comboBox1.Items.AddRange(st1);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            bool result1, result2;

            result1 = double.TryParse(textBox1.Text, out num1);
            result2 = double.TryParse(textBox2.Text, out num2);
            if (result1 ==true && result2 == true)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        num1 += num2;
                        break;
                    case 1:
                        num1 -= num2;
                        break;
                    case 2:
                        num1 *= num2;
                        break;
                    case 3:
                        num1 /= num2;
                        break;
                }
                if (result1 == true)
                    label1.Text = $"{num1}";
            }
            else
            {
                label1.Text = "輸入錯誤";
            }
        }


    }
}
