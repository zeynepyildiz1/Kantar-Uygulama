using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using DataLayer;
namespace KantarUygulama
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        Kantar sql = new Kantar();
        private void frmHome_Load(object sender, EventArgs e)
        {
         
            SqlDataAdapter da = sql.AracGoster();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            int sonuc = sql.AracSay();
            label1.Text = "İçerideki araç sayısı:" + sonuc.ToString();
            DateTime dt = DateTime.Now;
            string Tarih = dt.Day + "/" + dt.Month + "/" + dt.Year;
            string Saat = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
            label2.Text = "Hoşgeldin " + frmGiris.kullaniciadi+" "+Tarih+" "+Saat;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmCikis home = new frmCikis();
            this.Hide();
            home.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmAracGiris aracgiris = new frmAracGiris();
            aracgiris.Show();
            this.Hide();
        }

        private void btnOturum_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            this.Close();
            giris.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmRapor rapor = new frmRapor();
            rapor.Show();
            this.Hide();
        }
    }
}
