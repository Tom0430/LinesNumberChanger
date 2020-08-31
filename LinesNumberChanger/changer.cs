using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinesNumberChanger
{
    public static class Changer
    {
        public static void changeLinesNum(RichTextBox box, int changeNum)
        {
            if (box.Text == "")
            {
                return;
            }

            List<string> newLines = new List<string>();
            string[] lines = box.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                if (String.IsNullOrEmpty(line))
                {
                    continue;
                }

                var pattern = @"^\d+";
                var rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

                if (rx.Match(line).Value == "")
                {
                    newLines.Add(line);
                }
                else
                {
                    int lineNum = int.Parse(rx.Match(line).Value);
                    string AddedLineNum = (lineNum + changeNum).ToString();
                    string result = Regex.Replace(line, @"^\d+", AddedLineNum);
                    newLines.Add(result);
                }

            }
            box.Text = string.Join("\n", newLines.ToArray());
        }
    }
}
