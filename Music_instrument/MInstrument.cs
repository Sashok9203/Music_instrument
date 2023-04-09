using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_instrument
{
    enum InstrumentType
    {
        Key_MInstrument,
        Wind_MInstrument,
        Stringed_MInstrument
    }
    internal class MInstrument
    {
        private string? _name;
        public string Name 
        { 
            get => _name;
            private set 
            {
                if(String.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(" The name cannot be empty...");  
                _name = value;
            }
        }   
        public InstrumentType Type { get; init; }
        public virtual void PlaySound()
        {
            Console.WriteLine(" Sound is playing...\n\n");
        }
        protected MInstrument(string name,InstrumentType type)
        {
            Type = type;
            Name = name;
        }
        public override string ToString()
        {
            return $" -= {(Type == InstrumentType.Stringed_MInstrument? "Stringed musical instrument":
                            Type == InstrumentType.Wind_MInstrument? "Wind musical instrument " : " Key musical instrument") } =-\n" +
                   $"\tName    : {_name}\n";
        }
    }
}
