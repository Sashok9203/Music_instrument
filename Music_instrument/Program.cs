namespace Music_instrument
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MInstrument[] instruments =
            {
                new Guitar("Guitar",6,"Black","Wood"),
                new Flute ("Pan's Flute","Wood"),
                new Piano("Piano",108,"White")
            };
            foreach (var instr in instruments) 
            {
                Console.WriteLine(instr.ToString());
                instr.PlaySound();
            }
        }
    }
}