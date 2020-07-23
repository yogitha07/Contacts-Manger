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
    public partial class page3 : Form
    {
        contacts c = new contacts();
        public const int SIZE = 70;
        string name, phone, add, work, email;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("enter only numbers");
            }

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        { 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 p1 = new Form1();
            this.Hide();
            p1.Show();
        }

        public page3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            phone = textBox2.Text;
            add = textBox3.Text;
            work = textBox4.Text;
            email = textBox5.Text;
            c.name = name;
            c.phone = phone;
            c.address = add;
            c.work = work;
            c.email = email;
            string contactinfo =  "$" +c.name + "|" + c.phone + "|" + c.address + "|" + c.work + "|" + c.email;
            string path = @"C:\contactmanager.txt";
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                long len = contactinfo.Length;
                while (len<(SIZE-1))
                {
                    contactinfo = String.Concat(contactinfo,"-" );
                     len = len + 1;
                }
                List<string> member_line = File.ReadAllLines(path).ToList();
                member_line.Add(contactinfo.TrimStart());
                File.WriteAllLines(path, member_line);
                MessageBox.Show(" CONTACT SUCCESSFULLY ADDED ");
            }
            catch (Exception )
            {
                MessageBox.Show("oops!!something went wrong . Try again");
            }


        }
    }
}
