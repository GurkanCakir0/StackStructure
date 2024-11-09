using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Uygunluk(char a, char k)
        {
            return (a == '(' && k == ')') || (a == '{' && k == '}') || (a == '[' && k == ']');
        }

        private bool Kontrol(string parantez)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char char1 in parantez)
            {
                if (char1=='(' || char1=='[' || char1=='{')
                {
                    stack.Push(char1);
                }
                else if (char1== ')' || char1==']' || char1=='}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char al = stack.Pop();
                        if (!Uygunluk(al,char1))
                        {
                            return false;
                        }
                    }
                }
            }
            return stack.Count == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string parantez = textBox1.Text;

            if (Kontrol(parantez))
            {
                MessageBox.Show("Parantezler Uyuşuyor");
            }
            else
            {
                MessageBox.Show("Parantezlerden Biri veya Bir Kaçı Eksik");
            }
        }
    }
}
