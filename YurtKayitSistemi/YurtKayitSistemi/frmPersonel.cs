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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet6.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel(PersonelAdSoyad,PersonelDepartman) values(@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPersGorev.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);
            bgl.baglanti().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where PersonelId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Silindi");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtPersId.Text = id;
            txtPersAd.Text = ad;
            txtPersGorev.Text = gorev;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where PersonelId=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPersGorev.Text);
            komut.Parameters.AddWithValue("@p3", txtPersId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncellenme Gerçekleşti");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);
        }
    }
}
