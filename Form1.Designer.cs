using System.Drawing;
using System.Windows.Forms;

namespace ProjeSon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.grpEkle = new System.Windows.Forms.GroupBox();
            this.lblBaslikInput = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.lblAciklamaInput = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblTarihInput = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblSaatInput = new System.Windows.Forms.Label();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpListe = new System.Windows.Forms.GroupBox();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnBugun = new System.Windows.Forms.Button();
            this.btnYaklasan = new System.Windows.Forms.Button();
            this.btnTumEtkinlikler = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstEtkinlikler = new System.Windows.Forms.ListBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.uiTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.grpEkle.SuspendLayout();
            this.grpListe.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.lblBaslik);
            this.mainPanel.Controls.Add(this.grpEkle);
            this.mainPanel.Controls.Add(this.grpListe);
            this.mainPanel.Controls.Add(this.lblDurum);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(782, 553);
            this.mainPanel.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.Red;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(400, 40);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "📅 ETKİNLİK TAKVİMİ & HATIRLATICI";
            // 
            // grpEkle
            // 
            this.grpEkle.BackColor = System.Drawing.Color.White;
            this.grpEkle.Controls.Add(this.lblBaslikInput);
            this.grpEkle.Controls.Add(this.txtBaslik);
            this.grpEkle.Controls.Add(this.lblAciklamaInput);
            this.grpEkle.Controls.Add(this.txtAciklama);
            this.grpEkle.Controls.Add(this.lblTarihInput);
            this.grpEkle.Controls.Add(this.dtpTarih);
            this.grpEkle.Controls.Add(this.lblSaatInput);
            this.grpEkle.Controls.Add(this.dtpSaat);
            this.grpEkle.Controls.Add(this.btnEkle);
            this.grpEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpEkle.ForeColor = System.Drawing.Color.LightCoral;
            this.grpEkle.Location = new System.Drawing.Point(0, 50);
            this.grpEkle.Name = "grpEkle";
            this.grpEkle.Size = new System.Drawing.Size(350, 280);
            this.grpEkle.TabIndex = 1;
            this.grpEkle.TabStop = false;
            this.grpEkle.Text = "➕ Yeni Etkinlik Ekle";
            // 
            // lblBaslikInput
            // 
            this.lblBaslikInput.Location = new System.Drawing.Point(15, 30);
            this.lblBaslikInput.Name = "lblBaslikInput";
            this.lblBaslikInput.Size = new System.Drawing.Size(100, 20);
            this.lblBaslikInput.TabIndex = 0;
            this.lblBaslikInput.Text = "Etkinlik Başlığı:";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBaslik.Location = new System.Drawing.Point(15, 55);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(320, 27);
            this.txtBaslik.TabIndex = 1;
            // 
            // lblAciklamaInput
            // 
            this.lblAciklamaInput.Location = new System.Drawing.Point(15, 90);
            this.lblAciklamaInput.Name = "lblAciklamaInput";
            this.lblAciklamaInput.Size = new System.Drawing.Size(100, 20);
            this.lblAciklamaInput.TabIndex = 2;
            this.lblAciklamaInput.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAciklama.Location = new System.Drawing.Point(15, 115);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(320, 60);
            this.txtAciklama.TabIndex = 3;
            // 
            // lblTarihInput
            // 
            this.lblTarihInput.Location = new System.Drawing.Point(15, 185);
            this.lblTarihInput.Name = "lblTarihInput";
            this.lblTarihInput.Size = new System.Drawing.Size(50, 20);
            this.lblTarihInput.TabIndex = 4;
            this.lblTarihInput.Text = "Tarih:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(15, 210);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(150, 30);
            this.dtpTarih.TabIndex = 5;
            // 
            // lblSaatInput
            // 
            this.lblSaatInput.Location = new System.Drawing.Point(185, 185);
            this.lblSaatInput.Name = "lblSaatInput";
            this.lblSaatInput.Size = new System.Drawing.Size(50, 20);
            this.lblSaatInput.TabIndex = 6;
            this.lblSaatInput.Text = "Saat:";
            // 
            // dtpSaat
            // 
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(185, 210);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(150, 30);
            this.dtpSaat.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(15, 245);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(320, 30);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "✓ Etkinlik Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // grpListe
            // 
            this.grpListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpListe.BackColor = System.Drawing.Color.White;
            this.grpListe.Controls.Add(this.btnPanel);
            this.grpListe.Controls.Add(this.lstEtkinlikler);
            this.grpListe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.grpListe.Location = new System.Drawing.Point(370, 50);
            this.grpListe.Name = "grpListe";
            this.grpListe.Size = new System.Drawing.Size(390, 450);
            this.grpListe.TabIndex = 2;
            this.grpListe.TabStop = false;
            this.grpListe.Text = "📋 Etkinlikler";
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btnBugun);
            this.btnPanel.Controls.Add(this.btnYaklasan);
            this.btnPanel.Controls.Add(this.btnTumEtkinlikler);
            this.btnPanel.Controls.Add(this.btnSil);
            this.btnPanel.Location = new System.Drawing.Point(15, 25);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(360, 35);
            this.btnPanel.TabIndex = 0;
            // 
            // btnBugun
            // 
            this.btnBugun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnBugun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBugun.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBugun.ForeColor = System.Drawing.Color.White;
            this.btnBugun.Location = new System.Drawing.Point(0, 0);
            this.btnBugun.Name = "btnBugun";
            this.btnBugun.Size = new System.Drawing.Size(80, 30);
            this.btnBugun.TabIndex = 0;
            this.btnBugun.Text = "📅 Bugün";
            this.btnBugun.UseVisualStyleBackColor = false;
            this.btnBugun.Click += new System.EventHandler(this.BtnBugun_Click);
            // 
            // btnYaklasan
            // 
            this.btnYaklasan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnYaklasan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYaklasan.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnYaklasan.ForeColor = System.Drawing.Color.Black;
            this.btnYaklasan.Location = new System.Drawing.Point(94, 2);
            this.btnYaklasan.Name = "btnYaklasan";
            this.btnYaklasan.Size = new System.Drawing.Size(80, 30);
            this.btnYaklasan.TabIndex = 1;
            this.btnYaklasan.Text = "⏰ Yaklaşan";
            this.btnYaklasan.UseVisualStyleBackColor = false;
            this.btnYaklasan.Click += new System.EventHandler(this.btnYaklasan_Click_1);
            // 
            // btnTumEtkinlikler
            // 
            this.btnTumEtkinlikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnTumEtkinlikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumEtkinlikler.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnTumEtkinlikler.ForeColor = System.Drawing.Color.White;
            this.btnTumEtkinlikler.Location = new System.Drawing.Point(180, 0);
            this.btnTumEtkinlikler.Name = "btnTumEtkinlikler";
            this.btnTumEtkinlikler.Size = new System.Drawing.Size(80, 30);
            this.btnTumEtkinlikler.TabIndex = 2;
            this.btnTumEtkinlikler.Text = "📋 Tümü";
            this.btnTumEtkinlikler.UseVisualStyleBackColor = false;
            this.btnTumEtkinlikler.Enter += new System.EventHandler(this.BtnTumEtkinlikler_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(270, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "🗑️ Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // lstEtkinlikler
            // 
            this.lstEtkinlikler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEtkinlikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.lstEtkinlikler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstEtkinlikler.ItemHeight = 20;
            this.lstEtkinlikler.Location = new System.Drawing.Point(15, 70);
            this.lstEtkinlikler.Name = "lstEtkinlikler";
            this.lstEtkinlikler.Size = new System.Drawing.Size(360, 364);
            this.lstEtkinlikler.TabIndex = 1;
            // 
            // lblDurum
            // 
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblDurum.Location = new System.Drawing.Point(0, 350);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(300, 25);
            this.lblDurum.TabIndex = 3;
            this.lblDurum.Text = "⏰ Hatırlatıcı sistemi aktif";
            // 
            // uiTimer
            // 
            this.uiTimer.Enabled = true;
            this.uiTimer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📅 Etkinlik Takvimi & Hatırlatıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.grpEkle.ResumeLayout(false);
            this.grpEkle.PerformLayout();
            this.grpListe.ResumeLayout(false);
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Label lblBaslik;
        private GroupBox grpEkle;
        private Label lblBaslikInput;
        private Label lblAciklamaInput;
        private Label lblTarihInput;
        private Label lblSaatInput;
        private GroupBox grpListe;
        private Panel btnPanel;
        private Button btnTumEtkinlikler;
    }
}

