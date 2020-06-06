namespace KantarUygulama
{
    partial class frmCikis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCikis));
            this.txtSofor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCikisAgirligi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGirisAgirligi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAgirligi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnTart = new System.Windows.Forms.Button();
            this.btnOturum = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSofor
            // 
            this.txtSofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSofor.Location = new System.Drawing.Point(800, 83);
            this.txtSofor.Name = "txtSofor";
            this.txtSofor.Size = new System.Drawing.Size(134, 24);
            this.txtSofor.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(690, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şoför:";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(800, 41);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(134, 24);
            this.txtPlaka.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(690, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plaka:";
            // 
            // txtCikisAgirligi
            // 
            this.txtCikisAgirligi.Enabled = false;
            this.txtCikisAgirligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCikisAgirligi.Location = new System.Drawing.Point(800, 171);
            this.txtCikisAgirligi.Name = "txtCikisAgirligi";
            this.txtCikisAgirligi.Size = new System.Drawing.Size(134, 24);
            this.txtCikisAgirligi.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(690, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Çıkış Ağırlığı:";
            // 
            // txtGirisAgirligi
            // 
            this.txtGirisAgirligi.Enabled = false;
            this.txtGirisAgirligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisAgirligi.Location = new System.Drawing.Point(800, 127);
            this.txtGirisAgirligi.Name = "txtGirisAgirligi";
            this.txtGirisAgirligi.Size = new System.Drawing.Size(134, 24);
            this.txtGirisAgirligi.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(690, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giriş Ağırlığı:";
            // 
            // txtUrunAgirligi
            // 
            this.txtUrunAgirligi.Enabled = false;
            this.txtUrunAgirligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAgirligi.Location = new System.Drawing.Point(800, 216);
            this.txtUrunAgirligi.Name = "txtUrunAgirligi";
            this.txtUrunAgirligi.Size = new System.Drawing.Size(134, 24);
            this.txtUrunAgirligi.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(690, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ürün Ağırlığı";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.Black;
            this.btnKayit.Location = new System.Drawing.Point(800, 258);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(134, 46);
            this.btnKayit.TabIndex = 19;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.White;
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ForeColor = System.Drawing.Color.Crimson;
            this.btnRapor.Location = new System.Drawing.Point(26, 335);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(134, 70);
            this.btnRapor.TabIndex = 22;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Crimson;
            this.btnHome.Location = new System.Drawing.Point(26, 188);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 70);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Crimson;
            this.btnGiris.Location = new System.Drawing.Point(26, 31);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(134, 70);
            this.btnGiris.TabIndex = 20;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnTart
            // 
            this.btnTart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTart.ForeColor = System.Drawing.Color.Black;
            this.btnTart.Location = new System.Drawing.Point(953, 167);
            this.btnTart.Name = "btnTart";
            this.btnTart.Size = new System.Drawing.Size(88, 32);
            this.btnTart.TabIndex = 23;
            this.btnTart.Text = "Tart";
            this.btnTart.UseVisualStyleBackColor = false;
            this.btnTart.Click += new System.EventHandler(this.btnTart_Click);
            // 
            // btnOturum
            // 
            this.btnOturum.BackColor = System.Drawing.Color.White;
            this.btnOturum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOturum.BackgroundImage")));
            this.btnOturum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOturum.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnOturum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOturum.ForeColor = System.Drawing.Color.Black;
            this.btnOturum.Location = new System.Drawing.Point(962, 13);
            this.btnOturum.Name = "btnOturum";
            this.btnOturum.Size = new System.Drawing.Size(79, 55);
            this.btnOturum.TabIndex = 29;
            this.btnOturum.UseVisualStyleBackColor = false;
            this.btnOturum.Click += new System.EventHandler(this.btnOturum_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 374);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // frmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1053, 439);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOturum);
            this.Controls.Add(this.btnTart);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtUrunAgirligi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCikisAgirligi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGirisAgirligi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSofor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "frmCikis";
            this.Text = "Araç Çıkışı";
            this.Load += new System.EventHandler(this.frmCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSofor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCikisAgirligi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGirisAgirligi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunAgirligi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGiris;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnTart;
        private System.Windows.Forms.Button btnOturum;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}