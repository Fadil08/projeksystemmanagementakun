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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=projekpbo;");

        private void akun_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectakun = "select * from akun";
            //string tampinl = "select first_name || ' ' || last_name as nama " + datanama.Text + ", email '" + dataemail.Text + "' ,nomer_telp '" + datatelpon.Text + "', username'" + datausername.Text + "', password'" + datapassword.Text + "',deskripsi '" + dataketerangan.Text + "' from akun ";
            NpgsqlCommand cmd = new NpgsqlCommand(selectakun, conn);
            //database -> datatable -> textbox
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
           
        private void edit_Click(object sender, EventArgs e)
        {
            conn.Open();
            //string tampinl = "select first_name || ' ' || last_name as nama_lengkap "+datanama.Text+" ,email "+dataemail.Text+ ",nomer_telp "+ datatelpon.Text+", username"+datausername.Text+",password "+datapassword.Text+", deskripsi "+dataketerangan.Text+" from akun;";
            NpgsqlCommand cmd = new NpgsqlCommand();
            NpgsqlCommand command = conn.CreateCommand();
            NpgsqlDataReader reader = command.ExecuteReader();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }

        private void Account_Load(object sender, EventArgs e)
        {
            DataTable dataDT =new DataTable();
            conn.Open();
            string query = "select * from akun";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dataDT);
            }
            
            DataRow dr = dataDT.Rows[0];
            txnama.Text = dr["first_name"].ToString();

            

        }
    }
}