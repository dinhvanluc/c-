using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.sesion4
{
    public class Dog : Pet
    {
        public bool IsTrained { get; set; }
        public Dog(string name, int age, double weight, bool isTrained) : base(name, age, weight)
        {
            IsTrained = isTrained;
        }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Đã huấn luyện: {IsTrained}");
        }
        public override void MakeSuond()
        {
            Console.WriteLine($"{Name} sủa: Gâu gâu!");
        }
    }

}
