using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag4
{
    class Radio
    {
        private byte volym;
        private bool avPa;
        public double frekvens;
        static int instanceCount;

    

        public double Frekvens
        {
            get { return frekvens; }
            set
            {
                if(value >= 88.0 && value <= 176.0)
                frekvens = value;
                else throw new Exception("wrong frekvens");
            }
        }

        public bool AvPa
        {
            get { return avPa; }
            set { avPa = value; }
        }

        public byte Volym
        {
            get { return volym; }
            set
            {
                if (value >= 0 && value <= 100)
                volym = value;
                else throw new Exception("Hit that shit!");
            }
        }

        static Radio()
        {
            instanceCount = 0;
        }

        public Radio()
        {
            Frekvens = 101.6;
            Volym = 97;
            AvPa = false;
            instanceCount++;
        }

        public Radio(byte volym, double frekvens) : this()
        {
            Volym = volym;
            Frekvens = frekvens;
        }

        public Radio(double frekvens, byte volym, bool avPa) : this(volym, frekvens)
        {
            AvPa = avPa;
        }

        public override string ToString()
        {
            return $"Frekvens: {Frekvens} Volym: {Volym} Av/på: {AvPa} InstanceCount: {instanceCount}";

        }
    }
}
