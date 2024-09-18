using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamitogepEpites
{
    internal class Processzor
    {
        private double sebesseg;
        private string gyarto;

        public Processzor(double sebesseg, string gyarto)
        {
            this.Sebesseg = sebesseg;
            this.Gyarto = gyarto;
        }

        public double Sebesseg { get => sebesseg; set => sebesseg = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }

        public override string ToString()
        {
            return $"Gyártó: {Gyarto}, Sebesség: {Sebesseg} GHz";
        }
    }
}
