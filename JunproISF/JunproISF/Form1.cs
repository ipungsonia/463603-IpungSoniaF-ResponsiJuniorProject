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
using System.Xml.Linq;

namespace JunproISF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=respjunpro";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        public void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"select * from insertData(:_nama, :_idkar)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_nama", tbNama.Text);
            cmd.Parameters.AddWithValue("_idkar", cbDep.Text);
            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data karyawan berhasil ditambah", "Good Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                btnLoad.PerformClick();
                tbNama.Text = cbDep.Text = null;
            }
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"select * from updateData(:_name, :_idkar)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_name", tbNama.Text);
            cmd.Parameters.AddWithValue("_alamat", cbDep.Text);
            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data karyawan berhasil diedit", "Good Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                btnLoad.PerformClick();
                tbNama.Text = cbDep.Text = null;
                r = null;
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "select * from deleteData(:_idkar)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_idkar", r.Cells["_idkar"].Value.ToString());
            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Data karyawan berhasil dihapus", "Good Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                btnLoad.PerformClick();
                tbNama.Text = cbDep.Text = null;
                r = null;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvTabel.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_nama"].Value.ToString();
                cbDep.Text = r.Cells["_idkar"].Value.ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            conn.Open();
            dgvTabel.DataSource = null;
            sql = "select * from loadData()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvTabel.DataSource = dt;
            conn.Close();
        }
    }
}
