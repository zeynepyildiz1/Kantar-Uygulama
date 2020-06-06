namespace KantarUygulama
{
    partial class frmRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapor));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnOturum = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSofor = new System.Windows.Forms.Button();
            this.cmbSofor = new System.Windows.Forms.ComboBox();
            this.dgvSofor = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPlaka = new System.Windows.Forms.Button();
            this.cmbPlaka = new System.Windows.Forms.ComboBox();
            this.dgvPlaka = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tpTarih = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTarihGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTarih = new System.Windows.Forms.DataGridView();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAracCikis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCikisTarih = new System.Windows.Forms.DataGridView();
            this.dtpCikisBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpCikisBaslangic = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSofor)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaka)).BeginInit();
            this.tpTarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarih)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCikisTarih)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Crimson;
            this.btnCikis.Location = new System.Drawing.Point(12, 351);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(134, 70);
            this.btnCikis.TabIndex = 25;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Crimson;
            this.btnHome.Location = new System.Drawing.Point(12, 204);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 70);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Crimson;
            this.btnGiris.Location = new System.Drawing.Point(12, 47);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(134, 70);
            this.btnGiris.TabIndex = 23;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnOturum
            // 
            this.btnOturum.BackColor = System.Drawing.Color.White;
            this.btnOturum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOturum.BackgroundImage")));
            this.btnOturum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOturum.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnOturum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOturum.ForeColor = System.Drawing.Color.Black;
            this.btnOturum.Location = new System.Drawing.Point(807, 2);
            this.btnOturum.Name = "btnOturum";
            this.btnOturum.Size = new System.Drawing.Size(111, 63);
            this.btnOturum.TabIndex = 30;
            this.btnOturum.UseVisualStyleBackColor = false;
            this.btnOturum.Click += new System.EventHandler(this.btnOturum_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnSofor);
            this.tabPage1.Controls.Add(this.cmbSofor);
            this.tabPage1.Controls.Add(this.dgvSofor);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 348);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Şoför Sorgulama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSofor
            // 
            this.btnSofor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSofor.ForeColor = System.Drawing.Color.Black;
            this.btnSofor.Location = new System.Drawing.Point(156, 177);
            this.btnSofor.Name = "btnSofor";
            this.btnSofor.Size = new System.Drawing.Size(122, 46);
            this.btnSofor.TabIndex = 21;
            this.btnSofor.Text = "Giriş";
            this.btnSofor.UseVisualStyleBackColor = false;
            this.btnSofor.Click += new System.EventHandler(this.btnSofor_Click_1);
            // 
            // cmbSofor
            // 
            this.cmbSofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSofor.FormattingEnabled = true;
            this.cmbSofor.Location = new System.Drawing.Point(156, 123);
            this.cmbSofor.Name = "cmbSofor";
            this.cmbSofor.Size = new System.Drawing.Size(121, 26);
            this.cmbSofor.TabIndex = 20;
            // 
            // dgvSofor
            // 
            this.dgvSofor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSofor.Location = new System.Drawing.Point(306, 48);
            this.dgvSofor.Name = "dgvSofor";
            this.dgvSofor.Size = new System.Drawing.Size(435, 237);
            this.dgvSofor.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sorgulayacağınız\r\nŞoförü Seçiniz:\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnPlaka);
            this.tabPage2.Controls.Add(this.cmbPlaka);
            this.tabPage2.Controls.Add(this.dgvPlaka);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plaka Sorgulama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(616, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 46);
            this.button2.TabIndex = 18;
            this.button2.Text = "Excel\'e Aktar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlaka
            // 
            this.btnPlaka.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlaka.ForeColor = System.Drawing.Color.Black;
            this.btnPlaka.Location = new System.Drawing.Point(153, 165);
            this.btnPlaka.Name = "btnPlaka";
            this.btnPlaka.Size = new System.Drawing.Size(122, 46);
            this.btnPlaka.TabIndex = 17;
            this.btnPlaka.Text = "Giriş";
            this.btnPlaka.UseVisualStyleBackColor = false;
            this.btnPlaka.Click += new System.EventHandler(this.btnPlaka_Click_1);
            // 
            // cmbPlaka
            // 
            this.cmbPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPlaka.FormattingEnabled = true;
            this.cmbPlaka.Location = new System.Drawing.Point(153, 111);
            this.cmbPlaka.Name = "cmbPlaka";
            this.cmbPlaka.Size = new System.Drawing.Size(121, 26);
            this.cmbPlaka.TabIndex = 16;
            // 
            // dgvPlaka
            // 
            this.dgvPlaka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaka.Location = new System.Drawing.Point(303, 47);
            this.dgvPlaka.Name = "dgvPlaka";
            this.dgvPlaka.Size = new System.Drawing.Size(435, 226);
            this.dgvPlaka.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sorgulayacağınız\r\nPlakayı Seçiniz:";
            // 
            // tpTarih
            // 
            this.tpTarih.Controls.Add(this.button1);
            this.tpTarih.Controls.Add(this.btnTarihGiris);
            this.tpTarih.Controls.Add(this.label2);
            this.tpTarih.Controls.Add(this.label3);
            this.tpTarih.Controls.Add(this.dgvTarih);
            this.tpTarih.Controls.Add(this.dtpBitis);
            this.tpTarih.Controls.Add(this.dtpBaslangic);
            this.tpTarih.Location = new System.Drawing.Point(4, 22);
            this.tpTarih.Name = "tpTarih";
            this.tpTarih.Padding = new System.Windows.Forms.Padding(3);
            this.tpTarih.Size = new System.Drawing.Size(755, 348);
            this.tpTarih.TabIndex = 0;
            this.tpTarih.Text = "Giriş Sorgulama";
            this.tpTarih.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(612, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Excel\'e Aktar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTarihGiris
            // 
            this.btnTarihGiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTarihGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarihGiris.ForeColor = System.Drawing.Color.Black;
            this.btnTarihGiris.Location = new System.Drawing.Point(159, 168);
            this.btnTarihGiris.Name = "btnTarihGiris";
            this.btnTarihGiris.Size = new System.Drawing.Size(122, 46);
            this.btnTarihGiris.TabIndex = 10;
            this.btnTarihGiris.Text = "Giriş";
            this.btnTarihGiris.UseVisualStyleBackColor = false;
            this.btnTarihGiris.Click += new System.EventHandler(this.btnTarihGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Başlangıç Tarihi:";
            // 
            // dgvTarih
            // 
            this.dgvTarih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarih.Location = new System.Drawing.Point(299, 43);
            this.dgvTarih.Name = "dgvTarih";
            this.dgvTarih.Size = new System.Drawing.Size(435, 202);
            this.dgvTarih.TabIndex = 0;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(165, 123);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(116, 20);
            this.dtpBitis.TabIndex = 7;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CustomFormat = "yyyy-MM-dd";
            this.dtpBaslangic.Location = new System.Drawing.Point(165, 77);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(116, 20);
            this.dtpBaslangic.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTarih);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(173, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 374);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.btnAracCikis);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dgvCikisTarih);
            this.tabPage3.Controls.Add(this.dtpCikisBitis);
            this.tabPage3.Controls.Add(this.dtpCikisBaslangic);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(755, 348);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Çıkış Sorgulama";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAracCikis
            // 
            this.btnAracCikis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAracCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracCikis.ForeColor = System.Drawing.Color.Black;
            this.btnAracCikis.Location = new System.Drawing.Point(156, 198);
            this.btnAracCikis.Name = "btnAracCikis";
            this.btnAracCikis.Size = new System.Drawing.Size(122, 46);
            this.btnAracCikis.TabIndex = 16;
            this.btnAracCikis.Text = "Giriş";
            this.btnAracCikis.UseVisualStyleBackColor = false;
            this.btnAracCikis.Click += new System.EventHandler(this.btnAracCikis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bitiş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Başlangıç Tarihi:";
            // 
            // dgvCikisTarih
            // 
            this.dgvCikisTarih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCikisTarih.Location = new System.Drawing.Point(296, 73);
            this.dgvCikisTarih.Name = "dgvCikisTarih";
            this.dgvCikisTarih.Size = new System.Drawing.Size(435, 202);
            this.dgvCikisTarih.TabIndex = 11;
            // 
            // dtpCikisBitis
            // 
            this.dtpCikisBitis.Location = new System.Drawing.Point(162, 153);
            this.dtpCikisBitis.Name = "dtpCikisBitis";
            this.dtpCikisBitis.Size = new System.Drawing.Size(116, 20);
            this.dtpCikisBitis.TabIndex = 13;
            // 
            // dtpCikisBaslangic
            // 
            this.dtpCikisBaslangic.CustomFormat = "yyyy-MM-dd";
            this.dtpCikisBaslangic.Location = new System.Drawing.Point(162, 107);
            this.dtpCikisBaslangic.Name = "dtpCikisBaslangic";
            this.dtpCikisBaslangic.Size = new System.Drawing.Size(116, 20);
            this.dtpCikisBaslangic.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(619, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 46);
            this.button3.TabIndex = 22;
            this.button3.Text = "Excel\'e Aktar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(609, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 46);
            this.button4.TabIndex = 19;
            this.button4.Text = "Excel\'e Aktar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(989, 483);
            this.Controls.Add(this.btnOturum);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSofor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaka)).EndInit();
            this.tpTarih.ResumeLayout(false);
            this.tpTarih.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarih)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCikisTarih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnOturum;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSofor;
        private System.Windows.Forms.ComboBox cmbSofor;
        private System.Windows.Forms.DataGridView dgvSofor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPlaka;
        private System.Windows.Forms.ComboBox cmbPlaka;
        private System.Windows.Forms.DataGridView dgvPlaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpTarih;
        private System.Windows.Forms.Button btnTarihGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTarih;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAracCikis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvCikisTarih;
        private System.Windows.Forms.DateTimePicker dtpCikisBitis;
        private System.Windows.Forms.DateTimePicker dtpCikisBaslangic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}