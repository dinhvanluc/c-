using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.sesion4
{
    internal class Bird : Pet
    {
        public string Color { get; set; }
        public Bird(string name, int age, double weight, string color) : base(name, age, weight)
        {
            Color = color;
        }
        public override void MakeSuond()
        {
            Console.WriteLine($"{Name} chim: Chich chich!");
        }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Mau sac: {Color}");
        }
    }
}
