using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _0329
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Start";
        }

        string[] abc = new string[] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9"};

        Random rnd = new Random();
        Timer timer1 = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Stop")
            {
                button1.Text = "Start";
                timer1.Stop();
                timer1 = null;
                label1.Text = "";
            }
            else
            {
                button1.Text = "Stop";
                timer1= new Timer();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
                label1.Text = "請勾選";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==false && checkBox2.Checked == true)
            {
                label1.Text= abc[rnd.Next(0,26)];
            }else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                label1.Text = abc[rnd.Next(26, 36)];
            }
            else if (checkBox1.Checked && checkBox2.Checked == true)
            {
                label1.Text = abc[rnd.Next(0, 36)];
            }
            else
            {
                label1.Text = "請勾選";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(timer1 != null)
            {
                if (checkBox1.Checked && checkBox2.Checked == false)
                {
                    label1.Text = "請勾選";
                }
            }
            else
            {
                label1.Text = "";
            }
            
        }
    }
}
