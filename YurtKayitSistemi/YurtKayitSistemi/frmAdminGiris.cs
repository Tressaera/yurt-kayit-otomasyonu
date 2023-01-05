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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Admin where YoneticiAdi=@p1 and YoneticiSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtKad.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                frmAnaForm fr = new frmAnaForm();
                fr.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                txtKad.Clear();
                txtSifre.Clear();
                txtKad.Focus();
            }
            bgl.baglanti().Close();
        }

        private void frmAdminGiris_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
