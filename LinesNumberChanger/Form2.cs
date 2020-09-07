using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinesNumberChanger
{
    public partial class Form2 : Form
    {
        private string inputText;

        public Form2(string text)
        {
            InitializeComponent();
            inputText = text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                label2.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = maskedTextBox1.Text;
            string path = label2.Text;
            string fullPath = path + @"\" + fileName;
            string[] lines = inputText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            if (fileName == "")
            {
                label1.ForeColor = Color.Red;
            }

            if (path == "")
            {
                label2.Text = "選択してください";
                label2.ForeColor = Color.Red;
                return;
            }

            if (File.Exists(fullPath))
            {
                MessageBox.Show($"同名のファイルが存在します。" +
                                "ファイル名を変更するか、" +
                                "出力先を変更してください",
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                FileStream fs = File.Create(fullPath);
                using (var writer = new StreamWriter(fs))
                {
                    foreach (var line in lines)
                        writer.WriteLine(line);
                }
                this.Close();
            }

        }
    }
}
