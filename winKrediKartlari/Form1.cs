using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winKrediKartlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bankamatikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bankamatik kart1 = new Bankamatik();
            IHavale kav = (IHavale)kart1;

            Silver kart2 = new Silver();

            HavaleIslemi(kart1);
            HavaleIslemi(kart2);
        }

        public void HavaleIslemi(IHavale kart)
        {
            kart.HavaleGonder();
        }
    }
}
