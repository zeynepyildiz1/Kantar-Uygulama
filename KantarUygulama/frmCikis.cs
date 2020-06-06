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
    public partial class frmCikis : Form
    {
        public frmCikis()
        {
            InitializeComponent();
        }
        Kantar sql = new Kantar();
        int aracID;
        private void frmCikis_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ForeColor = Color.Black;
            SqlDataAdapter da = sql.AracGoster();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            btnTart.Enabled = false;
        }

        
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
                
                 int urunagirligi =(Convert.ToInt32(txtGirisAgirligi.Text) - Convert.ToInt32(txtCikisAgirligi.Text));
                if (urunagirligi < 0)
                {
                    urunagirligi = urunagirligi * -1;
                    txtUrunAgirligi.Text = urunagirligi.ToString();
                }
                else {
                    txtUrunAgirligi.Text = urunagirligi.ToString();
                }
                sql.AracCikis(aracID,Convert.ToInt32(txtCikisAgirligi.Text), urunagirligi, Tarih, Saat);
                MessageBox.Show("Araç çıkışı kaydedildi.");
                SqlDataAdapter da = sql.AracGoster();
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tbox = (TextBox)item;
                        tbox.Clear();
                    }
                }
            }
        }
        string port;
        private void btnTart_Click(object sender, EventArgs e)
        {
         

            for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
            {
                port = System.IO.Ports.SerialPort.GetPortNames()[i];
               
            }

                serialPort1.PortName = port;
                if (!serialPort1.IsOpen)
                    serialPort1.Open();

            try
            {
                serialPort1.Write("1");
                int receiveddata = Convert.ToInt16(serialPort1.ReadLine());
                //receiveddata = ((receiveddata * 5000) / 1023) / 10;
                txtCikisAgirligi.Text=receiveddata.ToString();
                System.Threading.Thread.Sleep(100);
                int urunagirligi =(Convert.ToInt32(txtGirisAgirligi.Text) - Convert.ToInt32(txtCikisAgirligi.Text));
                if (urunagirligi < 0) { urunagirligi = urunagirligi * -1; txtUrunAgirligi.Text = urunagirligi.ToString(); }
                else { txtUrunAgirligi.Text = urunagirligi.ToString(); }
                serialPort1.Close();
                
            }
            catch (Exception ex) { MessageBox.Show("Tartılamadı"); }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            frmAracGiris agir = new frmAracGiris();
                agir.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome anas = new frmHome();
                anas.Show();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (txtGirisAgirligi.Text == null) { btnTart.Enabled = false; }
            else { btnTart.Enabled = true; }
            txtPlaka.Text = dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString();
            txtSofor.Text = dataGridView1.CurrentRow.Cells["Şoför"].Value.ToString();
            txtGirisAgirligi.Text = dataGridView1.CurrentRow.Cells["Ağırlık"].Value.ToString();
            aracID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Sıra"].Value.ToString());
        }
    }
}
