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
    public partial class frmOgrDuzenle : Form
    {
        public frmOgrDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
       
        public string id,ad,soyad,TC,telefon,dogum,bolum;
        public string mail,odano,veliad,velitel,adres;
        private void frmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrId.Text = id;
            txtOgrAd.Text = ad;
            txtogrSoyad.Text = soyad;
            MskTc.Text = TC;
            MskOgrTelefon.Text= telefon;
            mskDogTar.Text = dogum;
            cmbBolum.Text = bolum;
            txtMail.Text = mail;
            cmbOdaNo.Text = odano;
            txtVeliAdSoyad.Text = veliad;
            mskVeliTelefon.Text = velitel;
            rchAdres.Text = adres;
        } 
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrıd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtOgrId.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
            komut.Parameters.AddWithValue("@p3", txtogrSoyad.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
            komut.Parameters.AddWithValue("@p6", mskDogTar.Text);
            komut.Parameters.AddWithValue("@p7", cmbBolum.Text);
            komut.Parameters.AddWithValue("@p8", txtMail.Text);
            komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
            komut.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
            komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
            komut.Parameters.AddWithValue("@p12", rchAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Başarıyla Güncellendi ");
            }

            catch (Exception){
            MessageBox.Show("Hata Tekrar Deneyiniz !");
            }
        }   
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where ogrıd=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1",txtOgrId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silindi");

            //Öğrenci Oda Kontenjanı azaltma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }


    }
}
