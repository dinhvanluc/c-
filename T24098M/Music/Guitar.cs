using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.Music
{
    public class Guitar : Instrument
    {
        public int NumberOfStrings { get; set; }

        public Guitar(string name, int year, int strings) : base(name, year)
        {
            NumberOfStrings = strings;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} is playing with {NumberOfStrings} strings!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Instrument: {Name}, Year: {Year}, Strings: {NumberOfStrings}");
        }
    }
}
