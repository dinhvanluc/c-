using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.Music
{
    public abstract class Instrument
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Instrument(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public abstract void Play();
        public abstract void ShowInfo();
    }
}
