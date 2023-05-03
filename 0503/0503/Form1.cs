using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0503
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Data
        {
            private string _name;
            public string Name 
            { 
                get=>_name; 
                set=>_name = value;            
            }
            
            private Bitmap _bitmap;
            public Bitmap bitmap 
            { 
                get=>_bitmap; 
                set=> _bitmap = value; 
            
            }
            
        }
        
        List<Data> datb = new List<Data>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    datb.Add(new Data() { Name = dlg.FileName, bitmap = new Bitmap(dlg.FileName) });
                    listBox1.Items.Add(dlg.FileName);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                  pictureBox1.Image = datb[listBox1.SelectedIndex].bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                pictureBox1.Image = null;
            }
        }
    }
}
