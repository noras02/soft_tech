using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class VillogGomb: Button //osztály neve mindig nagy betűvel kezdődik
    {
        public VillogGomb()
        {
            MouseEnter += VillogGomb_MouseEnter;
            MouseLeave += VillogGomb_MouseLeave;
        }

        private void VillogGomb_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Blue;

        }

        private void VillogGomb_MouseEnter(object sender, EventArgs e)
        {
            // throw new NotImplementedException(); //???
            BackColor = Color.Fuchsia;
        }
    }
}
