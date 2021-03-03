using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms_AwaitAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader str = new StreamReader("C:/New folder/file.txt"))
            {
                string s = str.ReadToEnd();
                count = s.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private async void btn(object sender, EventArgs e)
        {
            lbl1.Text = "Processing Files.....Please Wait";
            Task<int> t = new Task<int>(CountCharacters);
            t.Start();
            int c = await t;
            lbl1.Text = c.ToString()+" number of characters present in file";

        }
    }
}
