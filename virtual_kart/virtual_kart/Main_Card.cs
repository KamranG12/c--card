using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_kart
{
    class Main_Card
    {
        private int kartinNomresi;
        private string ad;
        private string soyad;
        private DateTime sonTarix;
        private int cvv;
        private int balans;

        public Main_Card(int kartnomresi,string name,string surname,DateTime tarix,int cvv,int balansin)
        {
            this.kartinNomresi = kartnomresi;
            this.ad = name;
            this.soyad = surname;
            this.sonTarix = tarix;
            this.cvv = cvv;
            this.balans = balansin;
        }

        public DateTime bitmeTarixi
        {
            get
            {
                return this.sonTarix;
            }
        }

        public int Balans
        {
            get
            {
                return this.balans;
            }
        }

    }
}
