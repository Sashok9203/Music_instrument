using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_instrument
{
    internal sealed class Guitar : StringedMusicalInstrument
    {
        public string Color { get; init; }
        public string Material { get; init; }
        public Guitar(string name, uint stringCount,string color,string material) : base(name, stringCount) 
        {
            if (String.IsNullOrWhiteSpace(material) || String.IsNullOrWhiteSpace(color)) throw new ArgumentException(" Invalid material or color string ");
            Material = material;   
            Color = color; 
        }
        public override void PlaySound()
        {
            Console.Write(" Guitar ");
            base.PlaySound();
        }
        public override string ToString()
        {
            return  base.ToString() +
                     $"\tColor   : {Color}\n" +
                     $"\tMaterial: {Material}\n";
        }
    }
}
