using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perpustakaan_Input
{
    public partial class PeminjamanBuku : Form
    {
        public static List<BukuPinjam> DaftarBukuPinjam = new List<BukuPinjam>();

        public PeminjamanBuku()
        {
            InitializeComponent();
            InitializeDataGridView();
            PopulateBookComboBox();
        }

        private void PopulateBookComboBox()
        {
            comboBoxJudulBuku.Items.Clear();
            foreach (var buku in ManagemenBuku.DaftarBuku)
            {
                comboBoxJudulBuku.Items.Add(buku.Judul);
            }
        }

        private void btnPinjamBuku_Click(object sender, EventArgs e)
        {
            string namaAnggota = txtNamaAnggota.Text;
            string judulBuku = comboBoxJudulBuku.SelectedItem?.ToString();
            DateTime tanggalPinjam = dateTimePicker1.Value;

            if (string.IsNullOrWhiteSpace(namaAnggota))
            {
                MessageBox.Show("Nama anggota tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(judulBuku))
            {
                MessageBox.Show("Pilih judul buku yang ingin dipinjam.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ManagemenBuku.DaftarBuku.Any(b => b.Judul == judulBuku))
            {
                BukuPinjam bukuDipinjam = new BukuPinjam
                {
                    NamaAnggota = namaAnggota,
                    JudulBuku = judulBuku,
                    TanggalPinjam = tanggalPinjam
                };

                DaftarBukuPinjam.Add(bukuDipinjam);
                RefreshDataGridView();
                MessageBox.Show("Buku berhasil dipinjam.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Buku tidak tersedia di perpustakaan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nama Peminjam";
            dataGridView1.Columns[1].Name = "Judul Buku";
            dataGridView1.Columns[2].Name = "Tanggal Pinjam";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in DaftarBukuPinjam)
            {
                dataGridView1.Rows.Add(item.NamaAnggota, item.JudulBuku, item.TanggalPinjam.ToShortDateString());
            }
        }

        private void ClearInputs()
        {
            txtNamaAnggota.Clear();
            comboBoxJudulBuku.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        public class BukuPinjam
        {
            public string NamaAnggota { get; set; }
            public string JudulBuku { get; set; }
            public DateTime TanggalPinjam { get; set; }
        }
    }
}
