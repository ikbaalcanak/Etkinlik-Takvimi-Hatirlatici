using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProjeSon
{
   
        public class KullaniciTakvimi : IReminder, IZamanlayici
        {
            private List<Etkinlik> etkinlikler;
            private Timer zamanlayici;
            internal Action OnEtkinlikListesiDegisti;

        
        public event Action<string> OnReminderTriggered;

            public KullaniciTakvimi()
            {
                etkinlikler = new List<Etkinlik>();

                
                zamanlayici = new Timer(30000); 
                zamanlayici.Elapsed += (sender, e) => CheckScheduledEvents();
            }

           
            public void EtkinlikEkle(string baslik, string aciklama, DateTime tarih, TimeSpan saat)
            {
                var yeniEtkinlik = new Etkinlik(baslik, aciklama, tarih, saat);
                etkinlikler.Add(yeniEtkinlik);
                Console.WriteLine($"✓ Etkinlik eklendi: {yeniEtkinlik}");
            }

            
            public bool EtkinlikSil(string id)
            {
                var etkinlik = etkinlikler.FirstOrDefault(e => e.Id == id);
                if (etkinlik != null)
                {
                    etkinlikler.Remove(etkinlik);
                    Console.WriteLine($"✓ Etkinlik silindi: {etkinlik.Baslik}");
                    return true;
                }

                Console.WriteLine("❌ Etkinlik bulunamadı!");
                return false;
            }

            
            public bool EtkinlikSil(string baslik, DateTime tarih)
            {
                var etkinlik = etkinlikler.FirstOrDefault(e =>
                    e.Baslik.Equals(baslik, StringComparison.OrdinalIgnoreCase) &&
                    e.Tarih.Date == tarih.Date);

                if (etkinlik != null)
                {
                    etkinlikler.Remove(etkinlik);
                    Console.WriteLine($"✓ Etkinlik silindi: {etkinlik.Baslik}");
                    return true;
                }

                Console.WriteLine("❌ Etkinlik bulunamadı!");
                return false;
            }

            
            public List<Etkinlik> TariheGoreListele(DateTime tarih)
            {
                return etkinlikler
                    .Where(e => e.Tarih.Date == tarih.Date)
                    .OrderBy(e => e.Saat)
                    .ToList();
            }

            
            public List<Etkinlik> TumEtkinlikleriListele()
            {
                return etkinlikler
                    .OrderBy(e => e.Tarih)
                    .ThenBy(e => e.Saat)
                    .ToList();
            }

            
            public List<Etkinlik> YaklasanEtkinlikler(int gunSayisi = 7)
            {
                var baslangic = DateTime.Now.Date;
                var bitis = baslangic.AddDays(gunSayisi);

                return etkinlikler
                    .Where(e => e.Tarih >= baslangic && e.Tarih <= bitis)
                    .OrderBy(e => e.Tarih)
                    .ThenBy(e => e.Saat)
                    .ToList();
            }

            
            public void SetReminder(DateTime reminderTime, string message)
            {
                Console.WriteLine($"🔔 Hatırlatıcı ayarlandı: {reminderTime:dd/MM/yyyy HH:mm} - {message}");
            }
            public void Start()
            {
                zamanlayici.Start();
                Console.WriteLine("⏰ Hatırlatıcı sistemi başlatıldı!");
            }

            public void Stop()
            {
                zamanlayici.Stop();
                Console.WriteLine("⏰ Hatırlatıcı sistemi durduruldu!");
            }

            public void CheckScheduledEvents()
            {
                var simdikiZaman = DateTime.Now;
                var hatirlatilacakEtkinlikler = etkinlikler
                    .Where(e => e.HatirlaticiAktif &&
                               e.HatirlaticiZamani <= simdikiZaman &&
                               e.TamZaman > simdikiZaman)
                    .ToList();

                foreach (var etkinlik in hatirlatilacakEtkinlikler)
                {
                    string mesaj = $"⏰ HATIRLATMA: '{etkinlik.Baslik}' etkinliğiniz {etkinlik.TamZaman:HH:mm}'de başlayacak!";
                    OnReminderTriggered?.Invoke(mesaj);
                    etkinlik.HatirlaticiAktif = false;
                }
            }

        }
    }
