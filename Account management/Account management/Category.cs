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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=projekpbo;");
        private void Add_Click(object sender, EventArgs e)
        {
            if (id_category.Text == "")
            {
                MessageBox.Show("Data cannot be Empty", "Information!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                conn.Open();
                string addcategory = "insert into category values("+id_category.Text+",'"+namaCategory.Text+"','"+deskripsi.Text+"')";
                NpgsqlCommand cmd = new NpgsqlCommand(addcategory,conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                id_category.Text = "@category_id";
                namaCategory.Text = "nama_category";
                deskripsi.Text = "@deskripsi";
                id_category.Text = "";
                namaCategory.Text = "";
                deskripsi.Text = "";
                MessageBox.Show("Category Created Sucsesfully", "Added Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showcategory();



                //showcategory();
            }
        }
        public void showcategory()
        {
            conn.Open();
            string selectquery = "select * from category";
            NpgsqlCommand cmd = new NpgsqlCommand(selectquery,conn);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //NpgsqlCommandBuilder built = new NpgsqlCommandBuilder(data);
            data.Fill(dt);
            cmd.Dispose();
            DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            string tampilcategory = " select * from category";
            NpgsqlCommand cmd = new NpgsqlCommand(tampilcategory, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            
        }

        private void closeN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (id_category.Text == "")
            {
                MessageBox.Show("Data cannot be Empty", "Information!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                conn.Open();
                string deleteQuery = "delete from data_akun where Id_akun=" + id_category.Text + "";
                NpgsqlCommand cmd = new NpgsqlCommand(deleteQuery, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                id_category.Text = "";
                MessageBox.Show("Category Deleted Sucsesfully", "Added Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showcategory();
            }
        }
    }
}
