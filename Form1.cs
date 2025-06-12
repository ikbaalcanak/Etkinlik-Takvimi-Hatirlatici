using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class Form1 : Form
    {
        private KullaniciTakvimi takvim;
        private ListBox lstEtkinlikler;
        private DateTimePicker dtpTarih;
        private DateTimePicker dtpSaat;
        private TextBox txtBaslik;
        private TextBox txtAciklama;
        private Button btnEkle;
        private Button btnSil;
        private Button btnBugun;
        private Button btnYaklasan;
        private Label lblDurum;
        private Timer uiTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeTakvim();
           
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeTakvim()
        {
            takvim = new KullaniciTakvimi();

            
            takvim.OnReminderTriggered += HatirlaticiMesajiGoster;
            takvim.OnEtkinlikListesiDegisti += EtkinlikListesiniGuncelle;

            
            takvim.Start();
        }

       

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBaslik.Text))
            {
                MessageBox.Show("⚠️ Lütfen etkinlik başlığını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            takvim.EtkinlikEkle(
                txtBaslik.Text.Trim(),
                txtAciklama.Text.Trim(),
                dtpTarih.Value.Date,
                dtpSaat.Value.TimeOfDay
            );

           
            txtBaslik.Clear();
            txtAciklama.Clear();
            dtpTarih.Value = DateTime.Now;
            dtpSaat.Value = DateTime.Now;

            MessageBox.Show("✅ Etkinlik başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lstEtkinlikler.SelectedItem == null)
            {
                MessageBox.Show("⚠️ Lütfen silinecek etkinliği seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var seciliEtkinlik = (Etkinlik)lstEtkinlikler.SelectedItem;

            var sonuc = MessageBox.Show(
                $"'{seciliEtkinlik.Baslik}' etkinliğini silmek istediğinizden emin misiniz?",
                "Etkinlik Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (sonuc == DialogResult.Yes)
            {
                takvim.EtkinlikSil(seciliEtkinlik.Id);
                MessageBox.Show("✅ Etkinlik başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBugun_Click(object sender, EventArgs e)
        {
            var bugunkuEtkinlikler = takvim.TariheGoreListele(DateTime.Now.Date);
            EtkinlikListesiniGoster(bugunkuEtkinlikler);
        }

        private void BtnYaklasan_Click(object sender, EventArgs e)
        {
            var yaklasanEtkinlikler = takvim.YaklasanEtkinlikler();
            EtkinlikListesiniGoster(yaklasanEtkinlikler);
        }

        private void BtnTumEtkinlikler_Click(object sender, EventArgs e)
        {
            var tumEtkinlikler = takvim.TumEtkinlikleriListele();
            EtkinlikListesiniGoster(tumEtkinlikler);
        }

        private void EtkinlikListesiniGuncelle()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(EtkinlikListesiniGuncelle));
                return;
            }

            
            var yaklasanEtkinlikler = takvim.YaklasanEtkinlikler();
            EtkinlikListesiniGoster(yaklasanEtkinlikler);
        }

        private void EtkinlikListesiniGoster(List<Etkinlik> etkinlikler)
        {
            lstEtkinlikler.Items.Clear();

            if (!etkinlikler.Any())
            {
                lstEtkinlikler.Items.Add("📭 Etkinlik bulunamadı");
                return;
            }

            foreach (var etkinlik in etkinlikler)
            {
                lstEtkinlikler.Items.Add(etkinlik);
            }
        }

        private void HatirlaticiMesajiGoster(string mesaj)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(HatirlaticiMesajiGoster), mesaj);
                return;
            }

           
            MessageBox.Show(mesaj, "⏰ Etkinlik Hatırlatıcısı", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            EtkinlikListesiniGuncelle();
        }

        private void UiTimer_Tick(object sender, EventArgs e)
        {
            lblDurum.Text = $"⏰ Hatırlatıcı aktif - {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            takvim?.Stop();
            uiTimer?.Stop();
            base.OnFormClosing(e);
        }

        private void btnYaklasan_Click_1(object sender, EventArgs e)
        {

        }
    }
}
