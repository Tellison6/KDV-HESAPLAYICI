using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1,secim;
            double kdv = 0.18;
            double kdv2 = 0.8;
            double kdv3 = 0.1;
            double sonuc,sonuc2;
            tekrar:
            Console.WriteLine("FIYATI GIRINIZ: ");
            sayı1 = int.Parse(Console.ReadLine());       
            Console.WriteLine("LUTFEN KDV ORANINI GIRINIZ: ");
            Thread.Sleep(1000);
            basla:
            try
            {
                Console.WriteLine("0.18 ICIN 1\n0.8 ICIN 2\n0.1 ICIN 3");
                secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    sonuc = sayı1 * kdv;
                    sonuc2 = (sayı1 * kdv) + sayı1;
                    Console.WriteLine("KDV EKLENMIS HALI:{0}", sonuc2);
                    Console.WriteLine("KDV EKLENMEMIS HALI:{0}", sonuc);

                }
                else if (secim == 2)
                {
                    sonuc = sayı1 * kdv2;
                    sonuc2 = (sayı1 * kdv2) + sayı1;
                    Console.WriteLine("KDV EKLENMIS HALI:{0}", sonuc2);
                    Console.WriteLine("KDV EKLENMEMIS HALI:{0}", sonuc);
                }
                else if (secim == 3)
                {
                    sonuc = sayı1 * kdv3;
                    sonuc2 = (sayı1 * kdv3) + sayı1;
                    Console.WriteLine("KDV EKLENMIS HALI:{0}", sonuc2);
                    Console.WriteLine("KDV EKLENMEMIS HALI:{0}", sonuc);
                }
                

            }
            catch (Exception)
            {
                Console.WriteLine("LUTFEN GECERLI BIR SECENEK GIRINIZ!");
                goto basla;
            }
            goto tekrar;
            Thread.Sleep(1000);

            Console.ReadLine();


        }
    }
}
