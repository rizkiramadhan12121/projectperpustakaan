using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perpustakaan_Input
{
    public partial class PengembalianBuku : Form
    {
        private List<BukuDikembalikan> daftarPengembalian = new List<BukuDikembalikan>();

        public PengembalianBuku()
        {
            InitializeComponent();
            InitializeDataGridView();
            PopulateBorrowedBooksComboBox();
        }

        private void PopulateBorrowedBooksComboBox()
        {
            comboBoxJudulBuku.Items.Clear();
            foreach (var buku in PeminjamanBuku.DaftarBukuPinjam)
            {
                // Add books that haven't been returned yet
                if (!daftarPengembalian.Any(b => b.JudulBuku == buku.JudulBuku && b.NamaAnggota == buku.NamaAnggota))
                {
                    comboBoxJudulBuku.Items.Add($"{buku.JudulBuku} - {buku.NamaAnggota}");
                }
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nama Anggota";
            dataGridView1.Columns[1].Name = "Judul Buku";
            dataGridView1.Columns[2].Name = "Tanggal Pengembalian";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in daftarPengembalian)
            {
                dataGridView1.Rows.Add(item.NamaAnggota, item.JudulBuku, item.TanggalPengembalian.ToShortDateString());
            }
        }

        private void btnKembalikanBuku_Click(object sender, EventArgs e)
        {
            string selectedBook = comboBoxJudulBuku.SelectedItem?.ToString();
            DateTime tanggalPengembalian = dateTimePicker1.Value;

            if (!string.IsNullOrWhiteSpace(selectedBook))
            {
                // Split the selected book information
                string[] parts = selectedBook.Split(new[] { " - " }, StringSplitOptions.None);
                if (parts.Length != 2)
                {
                    MessageBox.Show("Format buku yang dipilih tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string judulBuku = parts[0];
                string namaAnggota = parts[1];

                // Create and add the returned book to the list
                BukuDikembalikan bukuKembali = new BukuDikembalikan
                {
                    NamaAnggota = namaAnggota,
                    JudulBuku = judulBuku,
                    TanggalPengembalian = tanggalPengembalian
                };
                daftarPengembalian.Add(bukuKembali);

                // Update UI
                RefreshDataGridView();
                MessageBox.Show($"Buku berhasil dikembalikan. Terima kasih, {namaAnggota}!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateBorrowedBooksComboBox();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Harap pilih buku yang akan dikembalikan.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            comboBoxJudulBuku.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        public class BukuDikembalikan
        {
            public string NamaAnggota { get; set; }
            public string JudulBuku { get; set; }
            public DateTime TanggalPengembalian { get; set; }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
