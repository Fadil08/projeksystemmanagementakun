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
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
            
        }
        Category fromcategory = new Category();
        Dasboard fromdasboard = new Dasboard();
        list fromlist = new list();
        Note fromnote = new Note();
        Account fromacount = new Account();

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=projekpbo;");
       
        private void refresh()
        {
            conn.Close();
            Getselect();
            id_user.Clear();
            email.Clear();
            contact.Clear();
            user.Clear();
            Password.Clear();
            deskripsi.Clear();
            category.Clear();
        }
        public void Getselect()
        {
            conn.Open();
            string selectquery = "select * from data_akun";
            NpgsqlCommand cmd = new NpgsqlCommand(selectquery,conn);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //NpgsqlCommandBuilder built = new NpgsqlCommandBuilder(data);
            data.Fill(dt);
            cmd.Dispose();
            DataGridView1.DataSource = dt;
            conn.Close();
        }
        private void ubah()
        {
            conn.Open();
            string editquery = "update data_akun set(" + id_user.Text + ",'" + email.Text + "','" + contact.Text + "','" + user.Text + "','" + Password.Text + "','" + category.Text + "','" + deskripsi.Text + "')";
            NpgsqlCommand cmd = new NpgsqlCommand(editquery, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            Getselect();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string deleteQuery = "delete from data_akun where Id_akun=" + id_user.Text +"";
            NpgsqlCommand cmd = new NpgsqlCommand(deleteQuery, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            id_user.Text = "";
            MessageBox.Show("Account Deleted Sucsesfully", "Added Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Getselect();
        }

        private void closeN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void notes_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.Show();
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void edit_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "update data_akun set id_user=@id_akun, email=@email, contact=@contact, user=@username, password=@password category=@category, deskripsi=@deskripsi";
            cmd.Parameters.Add(new NpgsqlParameter("@id_akun", Convert.ToInt32(id_user.Text)));
            cmd.Parameters.Add(new NpgsqlParameter("@email", email.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@contact", contact.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@username", user.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@password", Password.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@category",category.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@deskripsi", deskripsi.Text));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            Getselect();
            refresh();
            MessageBox.Show("Account Deleted Sucsesfully", "Added Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnldata_Load(object sender, PaintEventArgs e)
        {
            
//            DataTable data_akunDT=new DataTable();
//;
//            Getselect();
//            conn.Open();
//            string query = "select * from data_akun";
//            using(NpgsqlCommand cmd = new NpgsqlCommand(query,conn))
//            {
//                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
//                da.Fill(data_akunDT);
//            }
//            DataGridView1.DataSource=data_akunDT;
        }

        private void akun_Click(object sender, EventArgs e)
        {
            Getselect();
        }

        private void list_Load(object sender, EventArgs e)
        {
            Getselect();
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                DataGridViewRow dr = DataGridView1.SelectedRows[0];
                id_user.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                email.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                contact.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                user.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                Password.Text = DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                category.Text = DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                deskripsi.Text = DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
