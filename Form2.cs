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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (Form1.Lsn1 == true)
            {
                btnLesson1.BackColor = Color.LimeGreen;
                btnLesson1.ForeColor = Color.White;
            }
            if (Form1.Lsn2 == true)
            {
                btnLesson2.BackColor = Color.LimeGreen;
                btnLesson1.ForeColor = Color.White;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnLesson1_Click(object sender, EventArgs e)
        {
            if(Form1.Lsn1 == false)
            {
                Lesson1 lesson1 = new Lesson1();
                lesson1.Owner = this;
                lesson1.StartPosition = FormStartPosition.Manual;
                lesson1.Location = this.Location;
                lesson1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have already completed this lesson!");
            }
            
        }

        private void btnLesson2_Click(object sender, EventArgs e)
        {
            Lesson2 lesson2 = new Lesson2();
            lesson2.Owner = this;
            lesson2.StartPosition = FormStartPosition.Manual;
            lesson2.Location = this.Location;
            lesson2.Show();
            this.Hide();
        }
    }
}
