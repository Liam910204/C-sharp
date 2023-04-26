using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0426
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] st2 = new string[10,20];
        string[,] st3 = new string[10, 20] ;
        string[] abc = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0;i<10; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    st2[i,j] =(abc[rnd.Next(0,20)]);
                }
            }
            for(int i = 0; i<10 ; i++)
            {
                for(int j = 0; j<20 ; j++)
                {
                    st3[i, j] = (rnd.Next(0,50).ToString());
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Clear();
                label1.Text = "";
                for(int i = 0;i<20 ; i++)
                {
                    listBox2.Items.Add(st2[listBox1.SelectedIndex, i]);
                }
            }
                
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
            {
                label1.Text = st3[listBox1.SelectedIndex, listBox2.SelectedIndex];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
