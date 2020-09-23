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
            Form2 f2 = new Form2(richTextBox1.Text);
            f2.ShowDialog();
            MessageBox.Show("ファイルが作成されました",
                                "ファイル作成完了",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
    }
}
