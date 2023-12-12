using Npgsql;
using System.Data;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Responsi
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=dityaDB";
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

            loadEntries();
        }

        private void loadEntries()
        {
            try
            {
                conn.Open();
                datagrid.DataSource = null;
                sql = @"select * from karyawan";
                //sql = @"select * from karyawan where id_dep = @id_departemen";
                cmd = new NpgsqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("id_departemen", 0);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                DataTable dt;
                dt = new DataTable();
                dt.Load(reader);
                datagrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addEntries()
        {
            try
            {
                conn.Open();
                sql = @"insert into karyawan(nama, id_dep) values (@nama, @id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nama", nameBox.Text);
                cmd.Parameters.AddWithValue("id_dep", deptBox.Text);
                cmd.ExecuteScalar();
                conn.Close();
                loadEntries();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editEntries()
        {
            try
            {
                conn.Open();
                sql = @"update karyawan set nama=@nama, id_dep=@id_dep where id_karyawan=@id_karyawan";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nama", nameBox.Text);
                cmd.Parameters.AddWithValue("id_dep", deptBox.Text);
                cmd.Parameters.AddWithValue("id_karyawan", r.Cells["id_karyawan"].Value);
                cmd.ExecuteScalar();
                conn.Close();
                loadEntries();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteEntries()
        {
            try
            {
                conn.Open();
                sql = @"delete from karyawan where id_karyawan=@id_karyawan";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id_karyawan", r.Cells["id_karyawan"].Value);
                cmd.ExecuteScalar();
                conn.Close();
                loadEntries();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            addEntries();
        }

        void updateData(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = datagrid.Rows[e.RowIndex];
                nameBox.Text = r.Cells["nama"].Value.ToString();
                deptBox.Text = r.Cells["id_dep"].Value.ToString();
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateData(e);
            Debug.WriteLine(e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editEntries();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteEntries();
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateData(e);
        }
    }
}