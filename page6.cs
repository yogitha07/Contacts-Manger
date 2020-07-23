using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace fsproject
{
    public partial class page6 : Form
    {
        public page6()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\contactmanager.txt";
            string sname = textBox1.Text;
            try
            {
                StreamReader s = new StreamReader(path);
                string currentLine;
                string searchString = sname;
                bool foundText = false;

                do
                {
                    currentLine = s.ReadLine();
                    if (currentLine != null)
                    {
                        foundText = currentLine.Contains(searchString);
                    }
                }
                while (currentLine != null && !foundText);

                if (foundText)
                {
                    textBox2.Text = currentLine;
                }
                else
                {
                    textBox2.Text = "CONTACT NOT FOUND";
                }

            }
            catch
            {

            }
                
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
    }

