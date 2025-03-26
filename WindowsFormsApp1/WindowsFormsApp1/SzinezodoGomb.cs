using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class SzinezodoGomb: Button
    {
        public SzinezodoGomb()
        {
            Click += SzinezodoGomb_Click;
        }

        private void SzinezodoGomb_Click(object sender, EventArgs e)
        {
            Width = 20; Height = 20;
            BackColor = Color.Fuchsia;
        }
    }
}
