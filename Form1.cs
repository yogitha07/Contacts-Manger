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
struct contacts
{
    public string name;
    public string phone;
    public string address;
    public string work;
    public string email;
};

namespace fsproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page2 p2 = new page2();
            this.Hide();
            p2.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page3 p3 = new fsproject.page3();
            this.Hide();
            p3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            page7 p7 = new page7();
            this.Hide();
            p7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            page6 p6 = new fsproject.page6();
            this.Hide();
            p6.Show();
        }
    }
}
