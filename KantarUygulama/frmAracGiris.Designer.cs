namespace KantarUygulama
{
    partial class frmAracGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracGiris));
            this.txtGirisAgirligi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSofor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblKg = new System.Windows.Forms.Label();
            this.btnOturum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGirisAgirligi
            // 
            this.txtGirisAgirligi.Enabled = false;
            this.txtGirisAgirligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisAgirligi.Location = new System.Drawing.Point(351, 224);
            this.txtGirisAgirligi.Name = "txtGirisAgirligi";
            this.txtGirisAgirligi.Size = new System.Drawing.Size(134, 24);
            this.txtGirisAgirligi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(241, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giriş Ağırlığı:";
            // 
            // txtSofor
            // 
            this.txtSofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSofor.Location = new System.Drawing.Point(351, 180);
            this.txtSofor.Name = "txtSofor";
            this.txtSofor.Size = new System.Drawing.Size(134, 24);
            this.txtSofor.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şoför:";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(351, 138);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(134, 24);
            this.txtPlaka.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(241, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Plaka:";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.Black;
            this.btnKayit.Location = new System.Drawing.Point(351, 277);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(134, 70);
            this.btnKayit.TabIndex = 21;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.White;
            this.btnRapor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ForeColor = System.Drawing.Color.Crimson;
            this.btnRapor.Location = new System.Drawing.Point(49, 275);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(134, 70);
            this.btnRapor.TabIndex = 25;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Crimson;
            this.btnHome.Location = new System.Drawing.Point(49, 36);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 70);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Crimson;
            this.btnCikis.Location = new System.Drawing.Point(49, 155);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(134, 70);
            this.btnCikis.TabIndex = 23;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTart
            // 
            this.btnTart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnTart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTart.ForeColor = System.Drawing.Color.Black;
            this.btnTart.Location = new System.Drawing.Point(509, 224);
            this.btnTart.Name = "btnTart";
            this.btnTart.Size = new System.Drawing.Size(101, 28);
            this.btnTart.TabIndex = 26;
            this.btnTart.Text = "Tart";
            this.btnTart.UseVisualStyleBackColor = false;
            this.btnTart.Click += new System.EventHandler(this.btnTart_Click);
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.BackColor = System.Drawing.Color.White;
            this.lblKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKg.ForeColor = System.Drawing.Color.Black;
            this.lblKg.Location = new System.Drawing.Point(321, 36);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(185, 73);
            this.lblKg.TabIndex = 27;
            this.lblKg.Text = "         ";
            // 
            // btnOturum
            // 
            this.btnOturum.BackColor = System.Drawing.Color.White;
            this.btnOturum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOturum.BackgroundImage")));
            this.btnOturum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOturum.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnOturum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOturum.ForeColor = System.Drawing.Color.Black;
            this.btnOturum.Location = new System.Drawing.Point(596, 16);
            this.btnOturum.Name = "btnOturum";
            this.btnOturum.Size = new System.Drawing.Size(94, 61);
            this.btnOturum.TabIndex = 28;
            this.btnOturum.UseVisualStyleBackColor = false;
            this.btnOturum.Click += new System.EventHandler(this.btnOturum_Click);
            // 
            // frmAracGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(730, 396);
            this.Controls.Add(this.btnOturum);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.btnTart);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtGirisAgirligi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSofor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label1);
            this.Name = "frmAracGiris";
            this.Text = "Araç Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirisAgirligi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSofor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTart;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Button btnOturum;
    }
}