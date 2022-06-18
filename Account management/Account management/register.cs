using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Account_management
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlogin fg = new Formlogin();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=projekpbo;");
            conn.Open();
            string insertquery = "insert into akun values ("+iduser.Text+",'" + firstname.Text + "','" + lastname.Text + "','" + contact.Text + "','" + username.Text + "','" + password.Text + "','" + email.Text + "','" + deskripsi.Text + "')";           
            NpgsqlCommand cmd = new NpgsqlCommand(insertquery,conn);
            iduser.Text = "";
            firstname.Text = "";
            lastname.Text = "";
            contact.Text = "";
            username.Text = "";
            password.Text = "";
            email.Text = "";
            deskripsi.Text = "";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Account Register Sucsesfully", "Added Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fg.Show();
            this.Hide();
        }
    }
}
