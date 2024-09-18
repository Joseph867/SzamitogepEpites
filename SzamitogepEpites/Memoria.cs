using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamitogepEpites
{
    internal class Memoria
    {
        private int meret;
        private string gyarto;

        public Memoria(int meret, string gyarto)
        {
            this.Meret = meret;
            this.Gyarto = gyarto;
        }

        public int Meret { get => meret; set => meret = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }

        public override string ToString()
        {
            return $"Gyártó: {Gyarto}, Méret: {Meret} GB";
        }
    }
}
