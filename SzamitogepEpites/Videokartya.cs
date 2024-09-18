using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamitogepEpites
{
    internal class Videokartya
    {
        private string gyarto;
        private int VRAM;

        public Videokartya(string gyarto, int VRAM)
        {
            this.Gyarto = gyarto;
            this.VRAM1 = VRAM;
        }

        public string Gyarto { get => gyarto; set => gyarto = value; }
        public int VRAM1 { get => VRAM; set => VRAM = value; }

        public override string ToString()
        {
            return $"Gyártó: {Gyarto}, VRAM: {VRAM} GB";
        }
    }
}
