using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace akun_management
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_MouseEnter(object sender, EventArgs e)
        {
            btnlogin.ForeColor = System.Drawing.Color.White;
        }

        private void regis_MouseEnter(object sender, EventArgs e)
        {
            regis.ForeColor = System.Drawing.Color.White;
        }

        private void regis_MouseLeave(object sender, EventArgs e)
        {
            regis.ForeColor = System.Drawing.Color.Blue;
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.ForeColor = System.Drawing.Color.Blue;
        }
    }
}