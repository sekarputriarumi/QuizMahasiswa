using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizMahasiswa
{
    public partial class MasterBarang025 : Form
    {
        public MasterBarang025()
        {
            InitializeComponent();
        }
        QuizMahasiswaDataContext db = new QuizMahasiswaDataContext();

        private void MasterBarang025_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            //con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (id_barang as int)), 0) +1 from tbl_barang", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //txtID.Text = dt.Rows[0][0].ToString();
            id_otomatis();
            LoadData();
        }

        void id_otomatis()
        {
            SqlConnection con = new SqlConnection(@"Integrated Security=true; Data Source=LAPTOP-2F1SV60V\MSSQLSERVER01; Initial Catalog=QUIZMAHASISWA");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (id_barang as int)), 0) +1 from tbl_barang", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();
        }
        void LoadData()
        {
            var st = from tb in db.tbl_barangs select tb;
            dataGridView1.DataSource = st;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nama = txtNama.Text;
            int harga = int.Parse(txtHarga.Text);
            int stok = int.Parse(txtStok.Text);
            string supplier = txtSupplier.Text;

            var data = new tbl_barang
            {
                id_barang = id,
                nama_barang = nama,
                harga = harga,
                stok = stok,
                nama_supplier = supplier,
            };
            db.tbl_barangs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Successfully");
            id_otomatis();
            txtNama.Clear();
            txtHarga.Clear();
            txtStok.Clear();
            txtSupplier.Clear();
            LoadData();
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
