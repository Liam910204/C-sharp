using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0315
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Load";
            Size = new Size(600, 300);
            BackColor = Color.Green;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //表單啟動時會執行from1_Activeated事件處理函式
            Text += ",Activated";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //表單重繪時會執行form1_paint事件函式
            Text += ",Paint";
        }

        private void Form1_Click(object sender, EventArgs e)
        { //表單上按一下滑鼠左鍵會執行form1_Click事件函式
            Text += ",Click";
            Width += 50;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {   //表單上快點兩下滑鼠左鍵會執行Form1_DoubleClick事件函式
            Text += ",DoubleClick";
        }
    }
}
