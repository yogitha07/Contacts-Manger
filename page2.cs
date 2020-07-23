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
    public partial class page2 : Form
    {
        public page2()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\contactmanager.txt";
            var str = File.ReadAllText(path);
            if( str==null)
            {
                MessageBox.Show("no contacts to display");
            }
            textBox1.Text = str;
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            Form1 p1 = new Form1();
            this.Hide();
            p1.Show();
        }
       

    }
}
