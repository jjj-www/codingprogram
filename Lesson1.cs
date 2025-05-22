using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heheheheh
{
    public partial class Lesson1 : Form
    {
        public Lesson1()
        {
            InitializeComponent();
        }

        private void btnPrc1_Click(object sender, EventArgs e)
        {
            string userInput = textAnswer1.Text;
            if (userInput == @"Console.WriteLine(""I love coding!"");")
            {
                MessageBox.Show("Great job!");
                Form1.Lsn1 = true;
                this.Owner.Show();
                this.Close();
            }    
            else
            {
                MessageBox.Show("KILL YOURSELF!");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ouch!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("no");
        }
    }
}
