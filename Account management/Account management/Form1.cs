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
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=projekpbo;");
            conn.Open();
            
            NpgsqlCommand dbcmd = conn.CreateCommand();
            string sql = "select user,password from formlogin";
            dbcmd.CommandText = sql;
            //NpgsqlCommand reader = dbcmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    if ((reader.GetString(0).ToString() == user) &&

            //    (reader.GetString(1).ToString() == password))
            //    {
            //        return true;
            //    }

            //}
            //db.Close();
            //return false;
            conn.Close();
        }
    }
}