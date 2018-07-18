using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace filing_exist_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "File Address ";
            this.label2.Text = "File Name";
            this.button1.Text = "Exist";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.textBox1.Text +"\\"+ this.textBox2.Text;
            if (File.Exists(s))
            {

                MessageBox.Show("File Exits");

            }
            else
            {

                MessageBox.Show("File Not Exist");
            
            }
        }
    }
}
