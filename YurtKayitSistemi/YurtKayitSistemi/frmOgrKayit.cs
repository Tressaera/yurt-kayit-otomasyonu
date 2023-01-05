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
    public partial class frmOgrKayit : Form
    {
        public frmOgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmOgrKayit_Load(object sender, EventArgs e)
        {
            //Bölümleri listeleme komutları
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()){

                cmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş odaları listeleme komutları
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerini Kaydetme işlemini sağlayacak
            try
            {
            SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
            komutkaydet.Parameters.AddWithValue("@p2", txtogrSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p3", MskTc.Text);
            komutkaydet.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p5", mskDogTar.Text);
            komutkaydet.Parameters.AddWithValue("@p6", cmbBolum.Text);
            komutkaydet.Parameters.AddWithValue("@p7", txtMail.Text);
            komutkaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
            komutkaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p11", rchAdres.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi");

            //Öğrenci Id'yi Label'a çekme
            SqlCommand komut = new SqlCommand("select Ogrıd from Ogrenci", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                 label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

            //Öğrenci borç alanı oluşturma
            SqlCommand komut2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values(@b1,@b2,@b3)",bgl.baglanti());
            komut2.Parameters.AddWithValue("@b1", label12.Text);
            komut2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
            komut2.Parameters.AddWithValue("@b3",txtogrSoyad.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            }
            catch(Exception)
            {
            MessageBox.Show("Hata!!! Lütfen Yeniden Deneyiniz");
            }

            //Öğrenci Oda Kontenjanı Artırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
//Data Source=X\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True 