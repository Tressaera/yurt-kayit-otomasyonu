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
    public partial class frmOdemeler : Form
    {
        public frmOdemeler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void frmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet2.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtKalan.Text = kalan;
            txtOgrId.Text = id;
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //ödenen tutarı kalan tutardan düşme.
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(txtOdenen.Text);
            kalan = Convert.ToInt16(txtKalan.Text);
            yeniborc = kalan - odenen;
            txtKalan.Text = yeniborc.ToString();

            //yeni tutarı veri tabanına kaydetme
            try
            {
                SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p2", txtOgrId.Text);
                komut.Parameters.AddWithValue("@p1", txtKalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ödeme Başarıyla Gerçekleştirildi");
                this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Ödeme Gerçekleştirilemedi !");
            }

            //kasa tablosuna ekleme yapma
            try { 
            SqlCommand komut2=new SqlCommand("insert into Kasa(OdemeAy,OdemeMiktar) values(@k1,@k2)",bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);
            MessageBox.Show("Başarıyla Eklendi");
            }
            catch (Exception)
            {
            MessageBox.Show("Hata Eklenemedi !");
            }

        }
    }
}
