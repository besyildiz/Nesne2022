using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama
{
    public class BenimSinifim:Ogretmen
    {
    }

    public class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    public class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }





}
