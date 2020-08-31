using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Changer.changeLinesNum(richTextBox1, 1);
        }
            
        private void buttonCountDown_Click(object sender, EventArgs e)
        {
            Changer.changeLinesNum(richTextBox1, -1);
        }
    }
}
