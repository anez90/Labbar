using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag4
{
    class Atv
    {
        private int color;

      

        private int horsePower;
        private int pullPower;
        private string brand;
        private static int instanceCount;
        public string Brand
        {
            get { return brand; }
            set

            {
                var storBokstav = value[0].ToString().ToUpper() == value[0].ToString();
                var valueValid = storBokstav;
                if (valueValid)
                brand = value;
                else throw new Exception("Enter uppercase letter");
            }
        }


        public int PullPower
        {
            get { return pullPower; }
            set
            {
                if (value >=0 && value <= 3500)
                pullPower = value;
                else throw new Exception("Too much!!");
            }
        }

  public int Color
        {
            get { return color; }
            set { color = value % 360; }
        }
        public int HorsePower
        {
            get { return horsePower; }
            set
            { 
                if (value >= 3 && value <= 365)
                horsePower = value;
                else throw new Exception("Either your  atv is to slow or to fast");
            }
        }

        static Atv()
        {
            instanceCount = 0;
        }

        public Atv()
        {
            horsePower = 300;
            pullPower = 3000;
            brand = "GasGas";
            Color = 350;
            instanceCount++;
        }
        public Atv(int horsePower, int pullPower, string brand, int color)
        {
            HorsePower = horsePower;
            PullPower = pullPower;
            Brand = brand;
            Color = color;
            instanceCount++;
        }

        public override string ToString()
        {
            return
                $"Horsepower: {HorsePower} Pullpower: {PullPower} Brand: {Brand} Color: {Color}Instancecount{instanceCount}";
        }
    }
}
