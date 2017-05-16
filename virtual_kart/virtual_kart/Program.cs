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
            DateTime a=Convert.ToDateTime("12.01.2017");
            Main_Card esaskart = new Main_Card(1000,"Kamran","Jabiyev",a,666,600);
            Virtual vrtcard = new Virtual();
            Console.Write("Virtual kartin hansi muddete qeder kecherli olacagini daxil edin:");
            DateTime add_date=Convert.ToDateTime(Console.ReadLine());
            int result = DateTime.Compare(add_date, esaskart.bitmeTarixi);
            string relationship;

           if (result <= 0)
                {
                relationship = "tarix qeyde alindi"; 
                vrtcard.getTarix=add_date;
                Console.WriteLine(relationship);
                Console.Write("Karta kochureceyiniz meblegi daxil edin:");
                int money=Convert.ToInt32(Console.ReadLine());
                if(money<=esaskart.Balans)
                 {
                   vrtcard.getMebleg=money;
                   Console.WriteLine("Mebleg virtual karta elave olundu");
                   Console.Write("Virtual karta ad daxil edin:");
                   vrtcard.getAd=Console.ReadLine();
                   Console.Write("Virtual karta soyad daxil edin:");
                   vrtcard.getSoyad=Console.ReadLine();

                   Console.Write("Yaradilmish virtual kartin gostericileri gosterilsinmi?(yes/no)");
                   if(Console.ReadLine()=="yes")
                   {
                    Console.WriteLine("\n"+"Ad,soyad:"+" "+vrtcard.getAd+" "+vrtcard.getSoyad+"\n"+"CVV:"+" "+vrtcard.getCvv()+"\n"+"Balans:"+" "+vrtcard.getMebleg+"\n"+"Son tarix:"+" "+vrtcard.getTarix+"\n"+"Kartin nomresi:"+" "+vrtcard.numberCard());
                   }
                 }else
                 {
                  Console.WriteLine("Esas kartinizin balansini ashirsiniz.Qeyd edek ki,kartinizda olan mebleg:"+esaskart.Balans);
                 }
                }
           else
                {
               Console.WriteLine
                    ("Esas kartin kecherlilik tarixini ashirsiniz.Kartinizin kecherlilik tarixi:"+a);
                }
            Console.ReadKey();
        }
    }
}
