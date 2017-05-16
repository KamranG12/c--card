using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_kart
{
    class Virtual
    {
        private int numbercard;
        private string ad;
        private string soyad;
        private DateTime tarix;
        private int cvv;
        private int mebleg;


        public DateTime getTarix
        {
            set
            {
                this.tarix = value;
            }
            get
            {
                return this.tarix;
            }
        }


        public int getMebleg
        {
            set
            {
                this.mebleg = value;
            }
            get
            {
                return this.mebleg;
            }
        }


        public string getAd
        {
            set
            {
                this.ad = value;
            }
            get
            {
                return this.ad;
            }
        }


        public string getSoyad
        {
            set
            {
                this.soyad = value;
            }
            get
            {
                return this.soyad;
            }
        }


        public int  getCvv()
        {
            Random rnd_cvv = new Random();
            cvv = rnd_cvv.Next(100, 900);
            return cvv;
        }


        public int  numberCard()
        {
            Random rnd = new Random();
            numbercard = rnd.Next(100000000, 900000000);
            return numbercard;
        }
    }
}
