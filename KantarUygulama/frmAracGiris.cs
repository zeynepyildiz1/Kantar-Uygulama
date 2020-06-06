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
namespace KantarUygulama
{
    public partial class frmAracGiris : Form
    {
        public frmAracGiris()
        {
            InitializeComponent();
        }
        Kantar sql = new Kantar();

        private void btnKayit_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string Tarih = dt.Day + "/" + dt.Month + "/" + dt.Year;
            string Saat = dt.Hour + ":" + dt.Minute + ":" + dt.Second;

            bool durum = true;
            bool kontrol = false;
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox && tb.Text == String.Empty) durum = false;
            }
            if (!durum) MessageBox.Show("Boş Alan Bırakmayınız.");
            else
            {

                sql.AracGiris(txtPlaka.Text, txtSofor.Text, frmGiris.kullanici, Tarih, Convert.ToInt32(txtGirisAgirligi.Text), Saat);
                MessageBox.Show("Araç girişi kaydedildi.");
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            lblKg.Text = "";
        }


            private void btnTart_Click(object sender, EventArgs e)
        {
            string port = "";

            for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
            {
                port = System.IO.Ports.SerialPort.GetPortNames()[i];
               
            }

            try
            {
                serialPort1.PortName = port;
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
            
            }
            catch
            {
                MessageBox.Show("Seri porta bağlı değil!!");
            }
            try
            {
                serialPort1.Write("1");
                int receiveddata = Convert.ToInt16(serialPort1.ReadLine());
                //receiveddata = ((receiveddata * 5000) / 1023) / 10;
                txtGirisAgirligi.Text=receiveddata.ToString();
               
                System.Threading.Thread.Sleep(100);
                lblKg.Text = receiveddata.ToString() + "kg";
                serialPort1.Close();

            }
            catch (Exception ex) { MessageBox.Show("Tartılamadı."); }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            serialPort1.Close();
            frmCikis cikis = new frmCikis();
            cikis.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome ana = new frmHome();
            ana.Show();
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
            frmRapor giris = new frmRapor();
            this.Close();
            giris.Show();
        }

       
    }
}
