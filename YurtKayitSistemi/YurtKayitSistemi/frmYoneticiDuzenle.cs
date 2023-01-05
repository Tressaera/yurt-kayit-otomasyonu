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

namespace YurtKayitSistemi
{
    public partial class frmYoneticiDuzenle : Form
    {
        public frmYoneticiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void frmYoneticiPaneli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet5.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into Admin(YoneticiAdi,YoneticiSifre) values(@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKad.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Kaydedildi");      
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);
            bgl.baglanti().Close();
         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtYoneticiId.Text = id;
            txtKad.Text = ad;
            txtSifre.Text = sifre;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Admin where YoneticiId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtYoneticiId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close(); 
            MessageBox.Show("Başarıyla Silindi");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Admin set YoneticiAdi=@p1,YoneticiSifre=@p2 where YoneticiId=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKad.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", txtYoneticiId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncellenme Gerçekleşti");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtYoneticiId.Text = id;
            txtKad.Text = ad;
            txtSifre.Text = sifre;
        }
    }
}
