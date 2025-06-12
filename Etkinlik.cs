using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon
{
    
    
        public class Etkinlik
        {
            public string Id { get; set; }
            public string Baslik { get; set; }
            public string Aciklama { get; set; }
            public DateTime Tarih { get; set; }
            public TimeSpan Saat { get; set; }
            public bool HatirlaticiAktif { get; set; }
            public DateTime HatirlaticiZamani { get; set; }

            public Etkinlik(string baslik, string aciklama, DateTime tarih, TimeSpan saat, bool hatirlaticiAktif = true)
            {
                Id = Guid.NewGuid().ToString();
                Baslik = baslik;
                Aciklama = aciklama;
                Tarih = tarih.Date;
                Saat = saat;
                HatirlaticiAktif = hatirlaticiAktif;

                var etkinlikZamani = Tarih.Add(Saat);
                HatirlaticiZamani = etkinlikZamani.AddMinutes(-15);
            }

            public DateTime TamZaman => Tarih.Add(Saat);

            public override string ToString()
            {
                return $"{Baslik} - {Tarih:dd/MM/yyyy} {Saat:hh\\:mm} - {Aciklama}";
            }
        }

    }

