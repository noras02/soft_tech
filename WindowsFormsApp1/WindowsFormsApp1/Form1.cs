using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 1000; //????
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool siker = int.TryParse(textBox1.Text, out int val);

            if (!siker) return;

            Random random = new Random();
            for (int i = 0; i < val; i++)
            {
                Button b = new Button();
                b.Left = random.Next(500);
                b.Top = random.Next(500);
                b.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                Controls.Add(b);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool succes = int.TryParse(textBox1.Text, out int val);
            if (!succes)
            {
                textBox1.BackColor = Color.Salmon;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int méret = 20;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    // VillogGomb villogGomb = new VillogGomb();
                    SzinezodoGomb szinezodoGomb = new SzinezodoGomb();
                    szinezodoGomb.Top = sor * méret;
                    szinezodoGomb.Left = oszlop * méret;
                    szinezodoGomb.Height = méret;
                    szinezodoGomb.Width = méret;
                    Controls.Add(szinezodoGomb);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int méret = 20;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor; oszlop++)
                {
                    KaracsonyfaGomb karacsonyfaGomb = new KaracsonyfaGomb();
                    karacsonyfaGomb.Top = sor * méret;
                    karacsonyfaGomb.Left = (oszlop * méret) + (Width / 2);
                    karacsonyfaGomb.Height = méret;
                    karacsonyfaGomb.Width = méret;
                    Controls.Add(karacsonyfaGomb);
                }
            }
        }
    }
}
