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
using System.Data.Sql;
using System.Data;
using DataLayer;
namespace KantarUygulama
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        Kantar sql = new Kantar();
        SqlDataReader reader;
        public static int kullanici;
        public static string kullaniciadi;
       

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtParola.Text == "") { MessageBox.Show("Lütfen boş alanları doldurunuz."); }
            else
            {
                reader = sql.prc_giris(txtKullaniciAdi.Text, txtParola.Text);
                if (reader.Read())
                {
                    kullaniciadi = txtKullaniciAdi.Text;
                    kullanici = Convert.ToInt32(reader[0].ToString());
                    frmHome home = new frmHome();
                    this.Hide();
                    home.Show();
                }
                else { MessageBox.Show("Hata"); }

            }
        }
    }
}
