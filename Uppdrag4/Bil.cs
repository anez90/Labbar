using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag4
{
    class Bil
    {
        private int vaxlar;
        private string marke;
        private int farg;
        private string typ;

        public string Typ
        {
            get { return typ; }
            set
            {
                if (value.ToLower() =="cupe" || value.ToLower() == "combi" )
               
                typ = value;
                else throw new Exception("Choose between cupe or combi!");
            }
        }
        
        public int Farg
        {
            get { return farg; }
            set
            {
                farg = value % 360;

               
            }
        }


        public string Marke
        {
            get { return marke; }
            set
            {
                if (value != null)
                    marke = value;
                else
                    throw new Exception("Please  pick a brand");
            }
        }


        public int Vaxlar
        {
            get { return vaxlar; }
            set
            {
                if (value >= 1 && value <= 6)

                    vaxlar = value;
                else
                    throw new Exception("Must be between 1-6 shifting gears");
            }
        }

        public Bil(int vaxlar, string marke, int farg, string typ)
        {
            Vaxlar = vaxlar;
            Marke = marke;
            Farg = farg;
            Typ = typ;
        }

        public override string ToString()
        {
            return
                $"Vaxlar: {Vaxlar} Marke: {Marke} Färg: {Farg} Typ: {Typ}";
        }
    }
}
