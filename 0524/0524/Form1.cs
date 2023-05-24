using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace _0524
{
    public partial class Form1 : Form
    {
        private Data data = new Data();
        private bool Onwork = false;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load1;
            CreatData();
        }

        private async void Form1_Load1(object sender, EventArgs e)
        {
            do
            {
                progressBar1.Maximum = data.MaxProgress;
                progressBar1.Value = data.Progress;

                listBox1.Enabled = !Onwork;
                textBox1.Enabled = !Onwork;
                button1.Enabled = !Onwork;
                await Task.Delay(16);
            } while (true);
        }

        private async void CreatData()
        {
            Onwork = true;

            await Task.Run(() =>
            {               
                data.MaxProgress = data.ItemList.GetLength(0);
                int Len = data.MaxProgress.ToString().Length;
                DateTime date = new DateTime();
                string dateNew = date.ToString("yyyyMMddHHmmss");

                for (int i = 0; i < data.MaxProgress; i++)
                {
                    string guid = Guid.NewGuid().ToString("N");
                    data.ItemList[i, 0] = dateNew + i.ToString("D"+Len);
                    data.ItemList[i, 1] = guid;
                    data.Progress++;
                }               
            });
            CreatItem();
            Onwork = false;


        }

        private async void CreatItem()
        {
            for(int i = 0; i < data.ItemList.GetLength(0); i++)
            {
                listBox1.Items.Add(data.ItemList[i,0]);
                await Task.Delay(16);
            }
        }

        private async void list_Click(object sender, EventArgs e)
        {
            if (Onwork == false)
            {
                Onwork = true;
                
                if(listBox1.SelectedIndex != -1)
                {
                    await CreatText();
                }
                Onwork = false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Onwork == false)
            {
                Onwork = true;

                if (listBox1.SelectedIndex != -1)
                {
                    int index = listBox1.SelectedIndex;
                    data.ItemList[index, 1] = textBox1.Text;

                    await CreatText();
                }
                Onwork = false;
            }
        }

        private async Task CreatText()
        {
            int index = listBox1.SelectedIndex;
            int Len = data.ItemList[index, 1].Length;
            char[] str = data.ItemList[index, 1].ToCharArray();
            textBox1.Text = "";

            data.MaxProgress = Len;

            for (int i = 0; i < Len; i++)
            {
                textBox1.Text += str[i];
                data.Progress++;
                await Task.Delay(50);
            }
        }

        private class Data
        {
            public string[,] ItemList { get; set; } = new string[100000, 2];

            #region Progress
            public int Progress { get; set; } = 0;

            private int _MaxProgress = 0;
            public int MaxProgress
            {
                get => _MaxProgress;
                set 
                {
                    if(value >= 0)
                    {
                        _MaxProgress = value;
                        Progress = 0;
                    }
                } 
            }
            #endregion
        }


    }
}
