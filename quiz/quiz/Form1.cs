using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("jatek.csv", true);
            int row = 0;
            while (!sr.EndOfStream)
            {
                if (row == 100) return; row++;
                string line = sr.ReadLine();
                string[] array = line.Split(';');
                if (array.Length != 6) continue;
                string question = array[0];
                string answer1 = array[1];
                string answer2 = array[2];
                string answer3 = array[3];
                string answer4 = array[4];
                int correct = int.Parse(array[5]);
                UserControl1 quc = new UserControl1(question, answer1, answer2, answer3, answer4, correct);
                Controls.Add(quc);
                quc.Top = quc.Height * row;
                row++;
            }
            sr.Close();
        }
    }
}
