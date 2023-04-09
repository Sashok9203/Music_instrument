using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Music_instrument
{
    internal class StringedMusicalInstrument : MInstrument
    {
        public uint StringCount { get; init; }
        public override void PlaySound()
        {
            Console.WriteLine(" plays using strings.");
            base.PlaySound();
        }
        protected StringedMusicalInstrument(string name, uint stringCount) : base(name, InstrumentType.Stringed_MInstrument)
        {
            if (stringCount == 0) throw new ApplicationException("Strings count cannot be zero...");
            StringCount = stringCount;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\tStrings : {StringCount}\n";
        }
    }
}
