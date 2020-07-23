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
    public partial class page7 : Form
    {
        public page7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\contactmanager.txt";
            //string tempFile = Path.GetTempFileName();
            string find = textBox1.Text;
            bool foundText = false;
            string currentLine;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {

                    do
                    {
                        currentLine = sr.ReadLine();
                        if (currentLine != null)
                        {
                            foundText = currentLine.Contains(find);
                        }
                    } while (currentLine != null && !foundText);
                }
                if (foundText)
                {
                    MessageBox.Show("RECORD DELETED");
                }
                else
                {
                    MessageBox.Show("RECORD NOT FOUND");
                }
                var oldLines = File.ReadAllLines(path);
                var newLines = oldLines.Where(line => !line.Contains(find));
                File.WriteAllLines(path, newLines);
            }
            catch
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            page8 p8 = new page8();
            p8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
