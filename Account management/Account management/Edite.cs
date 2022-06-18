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
    public partial class Edite : Form
    {
        public Edite()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=projekpbo;");
        private void submit_Click(object sender, EventArgs e)
        {
            string editquery = "update data_akun set(" + id_user.Text + ",'" + email.Text + "','" + contact.Text + "','" + username.Text + "','" + password.Text + "','" + category.Text + "','" + deskripsi.Text + "')";
            NpgsqlCommand cmd = new NpgsqlCommand(editquery, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
