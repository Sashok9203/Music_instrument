using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_instrument
{
    internal class WindMusicalInstrument : MInstrument
    {
        public override void PlaySound()
        {
            Console.WriteLine(" plays using the breath.");
            base.PlaySound();
        }
        protected WindMusicalInstrument(string name) : base(name, InstrumentType.Wind_MInstrument){}
    }
}
