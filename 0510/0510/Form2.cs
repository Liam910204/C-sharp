using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0510
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string abc { get;set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = abc;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abc = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
