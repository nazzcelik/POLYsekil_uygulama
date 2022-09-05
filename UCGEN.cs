using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYtest
{
    internal class UCGEN : SEKİL
    {
        public int taban { get; set; }
        public int yukseklik { get; set; }

        public UCGEN(string isim, int taban, int yukseklik) : base(isim)
        {
            this.taban = taban;
            this.yukseklik = yukseklik;
        }

        public override void SEKİL_HESAPLA()
        {
            base.SEKİL_HESAPLA();
            Console.WriteLine(getIsim()+"nin alanı : "+((taban*yukseklik)/2));
        }
        public override void SEKİL_BİLGİ()
        {
            base.SEKİL_BİLGİ();
            Console.WriteLine(getIsim()+"nin taban uzunluğu : "+taban);
            Console.WriteLine(getIsim() + "nin yüksekliği : " + taban);
        }
    }
}
