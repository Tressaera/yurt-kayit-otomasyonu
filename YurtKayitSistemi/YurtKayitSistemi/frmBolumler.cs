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
    public partial class frmBolumler : Form
    {
        public frmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

        }

        private void pcbEkle_Click(object sender, EventArgs e)
        {
            //Butona bastığımızda bölüm ekleniyor olmaktadır.
            try { 
            SqlCommand komut1 = new SqlCommand("insert into bolumler(BolumAd) values(@p1)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtBolumAd.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bölüm Eklendi");
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch(Exception)
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin");
            }
        }

        private void pcbSil_Click(object sender, EventArgs e)
        {
            //Butona bastığımızda bölüm silmekte oluyoruz.

            try { 
            SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtBolumId.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bölüm Başarılı Bir Şekilde Silindi");
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }

            catch(Exception)
            {
                MessageBox.Show("Başarısız Tekrar Deneyiniz !");
            }
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçtiğimiz belirli bir bölümü gösterir.
            int secilen;
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtBolumId.Text = id;
            txtBolumAd.Text = bolumad;
        }

        private void pcbDuzenle_Click(object sender, EventArgs e)
        {
            //Bölüm Güncelleme aşaması
            try { 
            SqlCommand komut2 = new SqlCommand("update Bolumler set BolumAd=@p1 where BolumID=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p2", txtBolumId.Text);
            komut2.Parameters.AddWithValue("@p1", txtBolumAd.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bölüm Başarıyla Güncellendi");
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch(Exception)
            {
            MessageBox.Show("Hata Tekrar Deneyiniz !");
            }
        }
    }
}
