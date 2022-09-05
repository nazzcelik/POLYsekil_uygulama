using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYtest
{
    internal class KARE: SEKİL
    {
        public int kenar { get; set; }
        public KARE(string isim, int kenar): base(isim)
        {
            this.kenar = kenar;
        }
        public override void SEKİL_HESAPLA()
        {
            base.SEKİL_HESAPLA();
            Console.WriteLine(getIsim()+"nin alanı : "+(kenar*kenar));
        }
        public override void SEKİL_BİLGİ()
        {
            base.SEKİL_BİLGİ();
            Console.WriteLine(getIsim()+"nin bir kenar uzunluğu : "+kenar);
        }
    }
}
