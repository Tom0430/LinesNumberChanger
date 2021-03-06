﻿using System;
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
        public static void ChangeLinesNum(RichTextBox box, int changeNum)
        {
            if (box.Text == "")
            {
                return;
            }

            box.Text = (Regex.Replace(box.Text, @"　", " "));
            var pattern = @"^\d+";
            var rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            List<string> newLines = new List<string>();
            string[] lines = box.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                if (String.IsNullOrEmpty(line) || rx.Match(line).Value == "")
                {
                    newLines.Add(line);
                }
                else
                {
                    string numHalfOnly= NumStr_FullToHalf(line);
                    int lineNum = int.Parse(rx.Match(numHalfOnly).Value);
                    int AddedLineNum = (lineNum + changeNum);

                    if(AddedLineNum < 0)
                    {
                        AddedLineNum = 0;
                    }

                    string fixedLine = Regex.Replace(line, @"^\d+", AddedLineNum.ToString());
                    newLines.Add(fixedLine);
                }
            }
            box.Text = string.Join("\n", newLines.ToArray());
        }
        private static string NumStr_FullToHalf(string strFull)
        {
            // strFullの中に全角数字０～９があればそれを半角数字に置換する関数

            string strHalf = "";
            for (int i = 0; i < strFull.Length; i++)
            {
                char cF = strFull[i];
                if ('０' <= cF && cF <= '９')
                {
                    var cHalf = (char)('0' + (cF - '０'));
                    strHalf += cHalf;
                }
                else
                {
                    strHalf += cF;
                }
            }
            return strHalf;
        }
    }
}
