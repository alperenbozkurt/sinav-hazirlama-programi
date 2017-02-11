using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinavHazirlamaProgrami
{
    public partial class hakkimizda : Form
    {
        public hakkimizda()
        {
            InitializeComponent();
        }

        private void hakkimizda_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
        int a = 0, c = 0, y = 0;
        string apo = "Abdulkadir BELKE\n240";
        string can = "Ali Can GÜNEŞ\n230";
        string alp = "Yasin Alperen BOZKURT\n232";
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a<=apo.Length -1)
            {
                lblApo.Text += apo[a];
                a++;
            }
            if (y<=alp.Length-1)
            {
                lblAlp.Text += alp[y];
                y++;
            }
            if (c<=can.Length-1)
            {
                lblCan.Text += can[c];
                c++;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (resimSeyi.Height >= 0)
            {
                resimSeyi.Height--;
                resimSeyi.Top++;
            }
        }
    }
}
