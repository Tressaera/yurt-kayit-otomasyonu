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
    public partial class frmGiderGuncelle : Form
    {
        public frmGiderGuncelle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        public string elektrik, su, dogalgaz, internet, gida, personel, diger, id;

        private void frmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtGiderİd.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtİnternet.Text = internet;
            txtGida.Text = gida;
            txtPersonel.Text = personel;
            txtDiger.Text = diger;
        }  
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut= new SqlCommand("update Odemeler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,internet=@p4,Gıda=@p5,Personel=@p6,Diger=@p7 where OdemeId=@p8", bgl.baglanti());
            komut.Parameters.AddWithValue("@p8", txtGiderİd.Text);
            komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
            komut.Parameters.AddWithValue("@p2", txtSu.Text);
            komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
            komut.Parameters.AddWithValue("@p4", txtİnternet.Text);
            komut.Parameters.AddWithValue("@p5", txtGida.Text);
            komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
            komut.Parameters.AddWithValue("@p7", txtDiger.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Yapıldı");
            }

            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin!");
            }
        }
    }
}
