using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.Music
{
    public class Piano : Instrument
    {
        public int Keys { get; set; }

        public Piano(string name, int year, int keys) : base(name, year)
        {
            Keys = keys;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} is playing with {Keys} keys!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Instrument: {Name}, Year: {Year}, Keys: {Keys}");
        }
    }
}
