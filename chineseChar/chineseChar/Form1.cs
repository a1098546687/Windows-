using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.International.Converters.PinYinConverter;
using System.Collections.ObjectModel;

namespace chineseChar
{
    public partial class Form1 : Form
    {
        public object Label1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                return;
            }
            char one_char = textBox1.Text.Trim().ToCharArray()[0];
            int ch_int = (int)one_char;
            if (ch_int > 127)
            {
                ChineseChar chineseChar = new ChineseChar(one_char);
                ReadOnlyCollection<String> pinyin = chineseChar.Pinyins;
                string pin_str = "";
                foreach(string pin in pinyin)
                {
                    pin_str += pin + "\r\n";
                }
                textBox2.Text = "";
                textBox2.Text = pin_str;
            }
        }
    }
}
