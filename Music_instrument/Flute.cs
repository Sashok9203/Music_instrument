using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_instrument
{
    internal sealed class Flute : WindMusicalInstrument
    {
        public string Material { get; init; }
        public Flute(string name, string material) : base(name)
        {
            if (String.IsNullOrWhiteSpace(material)) throw new ArgumentException(" Invalid material string ");
            Material = material;
        }
        public override void PlaySound()
        {
            Console.Write(" Flute ");
            base.PlaySound();
        }

        public override string ToString()
        {
            return base.ToString() + $"\tMaterial: {Material}\n";
        }
    }
}
