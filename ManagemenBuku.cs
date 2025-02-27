using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perpustakaan_Input
{
    public partial class ManagemenBuku : Form
    {
        public static List<Buku> DaftarBuku = new List<Buku>();

        public ManagemenBuku()
        {
            InitializeComponent();
            InitializeDataGridView();
            RefreshDataGridView();
        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            string judulBuku = txtJudulBuku.Text;
            string pengarang = txtPengarang.Text;
            string tahunPenerbit = txtTahunPenerbit.Text;

            if (!string.IsNullOrWhiteSpace(judulBuku) &&
                !string.IsNullOrWhiteSpace(pengarang) &&
                !string.IsNullOrWhiteSpace(tahunPenerbit))
            {
                Buku buku = new Buku
                {
                    Judul = judulBuku,
                    Pengarang = pengarang,
                    TahunPenerbit = tahunPenerbit
                };

                DaftarBuku.Add(buku);
                RefreshDataGridView();
                MessageBox.Show("Buku berhasil disimpan.");
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Harap lengkapi semua input.");
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Judul";
            dataGridView1.Columns[1].Name = "Pengarang";
            dataGridView1.Columns[2].Name = "Tahun Terbit";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in DaftarBuku)
            {
                dataGridView1.Rows.Add(item.Judul, item.Pengarang, item.TahunPenerbit);
            }
        }

        private void ClearInputs()
        {
            txtJudulBuku.Clear();
            txtPengarang.Clear();
            txtTahunPenerbit.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        public class Buku
        {
            public string Judul { get; set; }
            public string Pengarang { get; set; }
            public string TahunPenerbit { get; set; }
        }

        private void ManagemenBuku_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
