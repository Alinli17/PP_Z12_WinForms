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

namespace PP_Z12_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class RegExp
        {
            private Regex r;
            private string text;

            public RegExp(string pattern, string txt)
            {
                r = new Regex(pattern);
                text = txt;
            }

            public Regex R
            {
                get { return r; }
                set { r = value; }
            }

            public string Text
            {
                get { return text; }
                set { text = value; }
            }

            public object CheckType(int n)
            {
                if (n == 0)
                {
                    return new Regex("");
                }
                else if (n == 1)
                {
                    return "string";
                }

                return null;
            }

            public object this[int i]
            {
                set
                {

                    var result = CheckType(i);
                    if (result.GetType() == typeof(Regex))
                    {
                        R = (Regex)value;
                    }
                    else
                    {
                        text = value.ToString();
                    }
                }
                get
                {
                    var result = CheckType(i);
                    if (result.GetType() == typeof(Regex))
                    {
                        return R;
                    }
                    else
                    {
                        return text;
                    }

                }
            }
            public static string operator -(RegExp My)
            {
                MatchCollection m = My.r.Matches(My.text);
                string s = My.text;
                foreach (Match x in m)
                {
                    int i = s.IndexOf(x.Value);
                    int l = x.Value.Length;

                    s = s.Remove(i, l);
                }
                return s;
            }
            public static bool operator true(RegExp My)
            {
                if (My.text.Length != 0)
                    return true;
                else
                    return false;
            }
            public static bool operator false(RegExp My)
            {
                if (My.text.Length == 0)
                    return false;
                else
                    return true;
            }
            public static string operator +(RegExp My, string str)
            {
                My.Text += str;
                return My;
            }

            public static implicit operator string(RegExp r)
            {
                return r.ToString();
            }

            public static implicit operator Regex(RegExp text)
            {
                return new Regex(text);
            }
            public override string ToString()
            {
                return $"{text}";
            }
        }
        private void Result_Click(object sender, EventArgs e)
        {
            string text = "Мой телефон 8(926)123-45-67, а у мамы +7 926 123 45 67";
            string pattern = @"((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}";
            string s = "";
            s += "Строка текста:\n" + text + "\n";
            s += "\nРегулярное выражение:\n" + pattern + "\n";
            information.Text = s.ToString();
            RegExp My = new RegExp(pattern, text);
            unary_rez.Text =-My;
            if (My) text_rez.Text = "Поле text не пустое!";
            else text_rez.Text = "Поле text пустое!";
            binary_rez.Text = My + " - Это пример";
            indexer_0.Text = My[0].ToString();
            indexer_1.Text = My[1].ToString();
        }
    }
}
