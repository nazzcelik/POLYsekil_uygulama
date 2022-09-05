using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYtest
{
    internal class SEKİL
    {
        public string isim { get; set; }

        public SEKİL(string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return this.isim;
        }
        public void setIsim(string isim)
        {
            this.isim=isim;
        }

        public virtual void SEKİL_HESAPLA()
        {
            Console.WriteLine(getIsim()+"nin alanı hesaplanıyor...");
        }
        public virtual void SEKİL_BİLGİ()
        {
            Console.WriteLine("___________________________");
            Console.WriteLine(getIsim()+"nin bilgileri : ");
            Console.WriteLine("___________________________");
        }
    }
}
