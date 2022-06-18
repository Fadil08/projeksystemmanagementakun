using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_management
{
    public partial class Dasboard : Form
    {
        public Dasboard()
        {
            InitializeComponent();
        }
        int start = 0;
        private void  timer1_Tick(object sender, EventArgs e)
        {
            start += 2;
            if (ProgressBar1.Value == 100)
            {
                ProgressBar1.Value = 0;
                timer1.Stop();
                

            }
        }
        
        private void ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pnldata_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }
    }
}
