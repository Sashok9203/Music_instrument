using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_instrument
{
    internal sealed class Piano : KeyMusicalInstrument
    {
        public string Color { get; init; }
        public  Piano(string name, uint keyCount, string color) : base(name, keyCount)
        {
            if (String.IsNullOrWhiteSpace(color)) throw new ArgumentException(" Invalid color string ");
            Color = color;
        }
        public override void PlaySound()
        {
            Console.Write(" Piano ");
            base.PlaySound();
        }
        public override string ToString()
        {
            return base.ToString() + $"\tColor   : {Color}\n";
        }
    }
}
