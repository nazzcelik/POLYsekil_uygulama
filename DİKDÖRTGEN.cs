using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYtest
{
    internal class DİKDÖRTGEN : SEKİL
    {
        public int kısa_kenar { get; set; }
        public int uzun_kenar { get; set; }

        public DİKDÖRTGEN(string isim, int kısa_kenar, int uzun_kenar) : base(isim)
        {
            this.kısa_kenar = kısa_kenar;
            this.uzun_kenar = uzun_kenar;
        }
        public override void SEKİL_HESAPLA()
        {
            base.SEKİL_HESAPLA();
            Console.WriteLine(getIsim() + "nin alanı: " + (kısa_kenar * uzun_kenar));
        }
        public override void SEKİL_BİLGİ()
        {
            base.SEKİL_BİLGİ();
            Console.WriteLine(getIsim() + "nin uzun kenarı : " + this.uzun_kenar);
            Console.WriteLine(getIsim() + "nin kısa kenarı : " + this.kısa_kenar);
        }
    }
}
