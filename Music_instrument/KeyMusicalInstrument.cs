using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_instrument
{
    internal class KeyMusicalInstrument : MInstrument
    {
        public uint KeyCount { get; init; }
        public override void PlaySound()
        {
            Console.WriteLine(" plays using the keys.");
            base.PlaySound();
        }
       
        protected KeyMusicalInstrument(string name, uint keyCount) : base(name,InstrumentType.Key_MInstrument)
        {
            if (keyCount == 0) throw new ApplicationException("Keys count cannot be zero...");
            KeyCount = keyCount;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\tKeys    : {KeyCount}\n";
        }
    }
}
