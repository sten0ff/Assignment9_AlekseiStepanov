using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment9_AlekseiStepanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Count = new int[256];
            string str = textBox1.Text;
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                Count[str[i]]++;
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < Count[str[i]])
                {
                    maxCount = Count[str[i]];
                    character = str[i];
                }
            }
            label2.Text = ("The highest occurring character in the above string is: " + character);
            label2.Text += ("\nNumber of times this character occurs: " + maxCount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
