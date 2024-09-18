using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SzamitogepEpites
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szamitogep> szamitogepek = new List<Szamitogep>
            {
                new Szamitogep("gép1", new Processzor(3.4, "intel"), new Memoria(16, "Kingston"), new Videokartya("Nvidia", 8)),
                new Szamitogep("gép2", new Processzor(4.0, "AMD"), new Memoria(12, "Corsair"), new Videokartya("Nvidia", 16)),
                new Szamitogep("gép3", new Processzor(3.8, "intel"), new Memoria(8, "Kingston"), new Videokartya("Radeon", 16))
            };

            KiListazas(szamitogepek);
            Console.WriteLine();
            KiListazasVideokartyaAlapjan(szamitogepek, "Nvidia");
            Console.WriteLine();
            Console.ReadLine();

            /*Processzor processzor = new Processzor(3.4, "Intel");
            Memoria memoria = new Memoria(16, "Kingston");
            Videokartya videokartya = new Videokartya("Nvidia", 8);
            Szamitogep gep = new Szamitogep("Gép1", processzor, memoria, videokartya);
            Console.WriteLine(gep);
            Console.ReadLine();*/
        }
        static void KiListazas(List<Szamitogep> szamitogepek)
        {
            foreach (var szamitogep in szamitogepek)
            {
                Console.WriteLine(szamitogep);
            }
        }
        static void KiListazasVideokartyaAlapjan(List<Szamitogep> szamitogepek, string gyarto)
        {
            var videokartyaAlapjan = szamitogepek.Where(x => x.Videokartya.Gyarto == gyarto);
            foreach (var szamitogep in videokartyaAlapjan)
            {
                Console.WriteLine(szamitogep);
            }
        }
    }
}
