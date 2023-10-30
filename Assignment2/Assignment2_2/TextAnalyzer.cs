using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class TextAnalyzer
    {
        const string src = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private string text;

        public string GetText()
        {
            return text;
        }
        public void InitializeText(out string text)
        {
            int length = 50;
            string str = "";
            Random ran = new Random();
            for (int i = 0; i < length; i++)
            {
                char c = src[ran.Next(0, src.Length)];
                str += c;
            }
            text = str;
            this.text = text;
        }

        public SortedList<char, int> Collection()
        {
            SortedList<char, int> list = new SortedList<char, int>();
            foreach (char c in this.text)
            {
                if (!list.ContainsKey(c))
                    list.Add(c, 1);
                else
                    list[c] = list[c] + 1;
            }
            return list;
        }
    }
}
