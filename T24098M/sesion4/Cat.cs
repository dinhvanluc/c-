using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.sesion4
{
    internal class Cat : Pet
    {
       public string FruColor { get; set; }
         public Cat(string name, int age, double weight, string furColor) : base(name, age, weight)
          {
                FruColor = furColor;
          }
    
          public override void MakeSuond()
          {
                Console.WriteLine($"{Name} meo: Meo meo!");
          }
    
          public void ShowInfo()
          {
                base.ShowInfo();
                Console.WriteLine($"mau long : {FruColor}");
        }

    }
}
