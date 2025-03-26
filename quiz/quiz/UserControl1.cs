using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class UserControl1 : UserControl
    {
        int correctanswer;
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(string q, string a1, string a2, string a3, string a4, int correctanswer)
        {
            InitializeComponent();

            label1.Text = q;
            button1.Text = a1;
            button2.Text = a2;
            button3.Text = a3;
            button4.Text = a4;
            this.correctanswer = correctanswer;
        }
        void ColorGood()
        {
            if (correctanswer == 1) button1.BackColor = Color.Green;
            if (correctanswer == 2) button2.BackColor = Color.Green;
            if (correctanswer == 3) button3.BackColor = Color.Green;
            if (correctanswer == 4) button4.BackColor = Color.Green;
            Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            ColorGood();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            ColorGood();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            ColorGood();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            ColorGood();
        }
    }
}
