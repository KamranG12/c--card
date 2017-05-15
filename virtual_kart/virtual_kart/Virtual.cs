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
        private DateTime tarix;


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





        public int  numberCard()
        {
            Random rnd = new Random();
            numbercard = rnd.Next(100, 900);
            return numbercard;
        }
    }
}
