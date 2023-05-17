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
    public partial class Form2 : Form
    {
        public delegate void Del();
        public event Del IsClosed;
        public Form2()
        {
            InitializeComponent();
            TopMost = true;
            label1.Text = Class1.NME;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed?.Invoke();
        }
    }
}
