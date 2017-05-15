using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using virtual_kart;

namespace virtual_kart
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Main_Card esaskart = new Main_Card(1000,"Kamran","Jabiyev",01/12/2017,666,600);
            Virtual vrtcard = new Virtual();
            Console.WriteLine(vrtcard.numberCard());
            Console.ReadLine();
            Console.Write("Adi daxil et:");
            vrtcard.getAd = Console.ReadLine();
            Console.Write("Kartinizin bitme tarixini daxil edin:");
            vrtcard.getTarix = Convert.ToDateTime(Console.ReadLine());

        }
    }
}
