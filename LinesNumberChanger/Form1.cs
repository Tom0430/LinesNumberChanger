using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinesNumberChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCountUp_Click(object sender, EventArgs e)
        {
            Changer.ChangeLinesNum(richTextBox1, 1);
        }
            
        private void buttonCountDown_Click(object sender, EventArgs e)
        {
            Changer.ChangeLinesNum(richTextBox1, -1);
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            //var filePath = @"C:\Users\ttaka\OneDrive\デスクトップ\test.txt";
            //string[] lines = richTextBox1.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            //if (File.Exists(filePath))
            //{
            //    File.WriteAllLines(filePath, lines);
            //}
            //else
            //{

            //}
            //Form.ShowDialog( );

            Form2 f2 = new Form2();
            //Clickイベントハンドラを追加
            //f2.Click += new EventHandler(f2_Click);

            f2.ShowDialog();


            //終了時にメッセージボックスを表示
            MessageBox.Show("Application End");
        }
    }
}
