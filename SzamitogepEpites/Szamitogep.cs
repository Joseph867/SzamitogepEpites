using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SzamitogepEpites
{
    internal class Szamitogep
    {
        private string nev;
        private Processzor processzor;
        private Memoria memoria;
        private Videokartya videokartya;

        public Szamitogep(string nev, Processzor processzor, Memoria memoria, Videokartya videokartya)
        {
            this.Nev = nev;
            this.Processzor = processzor;
            this.Memoria = memoria;
            this.Videokartya = videokartya;
        }

        public string Nev { get => nev; set => nev = value; }
        internal Processzor Processzor { get => processzor; set => processzor = value; }
        internal Memoria Memoria { get => memoria; set => memoria = value; }
        internal Videokartya Videokartya { get => videokartya; set => videokartya = value; }

        public override string ToString()
        {
            return $"Név: {Nev}\n{Processzor}\n{Memoria}\n{Videokartya}";
        }
    }
}
