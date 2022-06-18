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
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }
        list list = new list();

        private void Create_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Data cannot be Empty", "Information!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=projekpbo;");
                conn.Open();
                string insertquery = "insert into data_akun values(" + id.Text + ",'" + mail.Text + "','" + tlph.Text + "','" + user.Text + "','" + passwd.Text + "','" + ctgry.Text + "','" + deskripsi.Text + "')";
                NpgsqlCommand cmd = new NpgsqlCommand(insertquery, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                id.Text = "@id_akun";
                mail.Text = "@email";
                tlph.Text = "@nomer";
                user.Text = "@username";
                passwd.Text = "@password";
                ctgry.Text = "@category";
                deskripsi.Text = "@deskripsi";
                id.Text = "";
                mail.Text = "";
                tlph.Text = "";
                user.Text = "";
                passwd.Text = "";
                ctgry.Text = "";               
                deskripsi.Text = "";
                MessageBox.Show("Account Created Sucsesfully", "Added Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list.Getselect();
                
            }

        }

        private void closeN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void show_Click(object sender, EventArgs e)
        {
            list ls = new list();
            ls.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Dasboard ds = new Dasboard();
            ds.Show();
            this.Hide();
        }
    }
}
