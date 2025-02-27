using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan_Input
{
    public partial class ManagemenPerpustakaan : Form
    {
        public ManagemenPerpustakaan()
        {
            InitializeComponent();
        }

        private void managemenPerpusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagemenBuku formManagemen = new ManagemenBuku();
            formManagemen.MdiParent = this;
            formManagemen.Show();
        }

        private void peminjamanBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeminjamanBuku Peminjaman = new PeminjamanBuku();
            Peminjaman.MdiParent = this;
            Peminjaman.Show();
        }

        private void pengembalianBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PengembalianBuku Pengembalianbuku = new PengembalianBuku();
            Pengembalianbuku.MdiParent = this;
            Pengembalianbuku.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tentangAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi Manajemen Perpustkaan v1.0\nPengembang: Kelompok ", "Tentang Aplikasi");
        }
    }
}
