using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.NME = textBox1.Text;
            Form2 form2 = new Form2();
            form2.IsClosed += () =>
            {
                form2 = null;
                Enabled = true;
            };
            form2.Show();
            Enabled = false;
        }
    }
}
