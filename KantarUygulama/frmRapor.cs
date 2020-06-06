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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;



namespace KantarUygulama
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }
        Kantar sql = new Kantar();
        SqlDataReader reader;

        private void btnTarihGiris_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
    
            SqlDataAdapter da = sql.TarihSirala(dtpBaslangic.Value.ToShortDateString(), dtpBitis.Value.ToShortDateString());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTarih.DataSource = ds.Tables[0];
        }
        
        private void frmRapor_Load(object sender, EventArgs e)
        {
            cmbPlaka.Items.Clear();
            cmbPlaka.Items.Clear();
            reader = sql.prc_Plaka();
            while (reader.Read())
            {
                cmbPlaka.Items.Add(reader[0].ToString());
            }
            
            reader = sql.prc_Sofor();
            while (reader.Read())
            {
                cmbSofor.Items.Add(reader[0].ToString());
            }
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            frmAracGiris agir = new frmAracGiris();
            agir.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome ana = new frmHome();
            ana.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmCikis ana = new frmCikis();
            ana.Show();
            this.Hide();

        }

        private void btnOturum_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            this.Close();
            giris.Show();
        }

        private void btnSofor_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = sql.SoforSorgu(cmbSofor.SelectedItem.ToString());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvSofor.DataSource = ds.Tables[0];
        }

        private void btnPlaka_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = sql.PlakaSorgu(cmbPlaka.SelectedItem.ToString());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvPlaka.DataSource = ds.Tables[0];
        }

        private void btnAracCikis_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = sql.CikisTarihSirala(dtpCikisBaslangic.Value.ToShortDateString(), dtpCikisBitis.Value.ToShortDateString());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCikisTarih.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Visible = true;
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            sheet1 = workbook.ActiveSheet;
            sheet1.Name = "Exported from gridview";
            for (int i = 1; i < dgvTarih.Columns.Count + 1; i++)
            {
                sheet1.Cells[1, i] = dgvTarih.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvTarih.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvTarih.Columns.Count; j++)
                {
                    sheet1.Cells[i + 2, j + 1] = dgvTarih.Rows[i].Cells[j].Value.ToString();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Visible = true;
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            sheet1 = workbook.ActiveSheet;
            sheet1.Name = "Exported from gridview";
            for (int i = 1; i < dgvPlaka.Columns.Count + 1; i++)
            {
                sheet1.Cells[1, i] = dgvPlaka.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvPlaka.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvPlaka.Columns.Count; j++)
                {
                    sheet1.Cells[i + 2, j + 1] = dgvPlaka.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Visible = true;
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            sheet1 = workbook.ActiveSheet;
            sheet1.Name = "Exported from gridview";
            for (int i = 1; i < dgvSofor.Columns.Count + 1; i++)
            {
                sheet1.Cells[1, i] = dgvSofor.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvSofor.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvSofor.Columns.Count; j++)
                {
                    sheet1.Cells[i + 2, j + 1] = dgvSofor.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Visible = true;
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            sheet1 = workbook.ActiveSheet;
            sheet1.Name = "Exported from gridview";
            for (int i = 1; i < dgvCikisTarih.Columns.Count + 1; i++)
            {
                sheet1.Cells[1, i] = dgvCikisTarih.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvCikisTarih.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvCikisTarih.Columns.Count; j++)
                {
                    sheet1.Cells[i + 2, j + 1] = dgvCikisTarih.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}
