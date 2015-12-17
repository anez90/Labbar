using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil = new Bil(vaxlar:5, marke:"Volvo",farg:246, typ:"cupe");
            Console.WriteLine(bil);
            
            

            var radio = new Radio();
            var radio1 = new Radio(frekvens: 100.6, volym: 55, avPa: true);
            var radio2 = new Radio(frekvens: 99.8, volym: 77, avPa:true);
            var radio3 = new Radio(frekvens: 103.6, volym: 99, avPa: true);
            Console.WriteLine(radio1);
            Console.WriteLine(radio2);
            Console.WriteLine(radio3);

            var atv = new Atv();
            var atv1 = new Atv(horsePower: 236, pullPower: 2400, brand: "Gasgas",color: 150);
            var atv2 = new Atv(horsePower: 136, pullPower: 1400, brand: "Yamaha", color: 350);
            var atv3 = new Atv(horsePower: 300, pullPower: 1400, brand: "Canam", color: 50);
            Console.WriteLine(atv1);
            Console.WriteLine(atv2);
            Console.WriteLine(atv3);
            Console.ReadLine();
        }
    }
}
