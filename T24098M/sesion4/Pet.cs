using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.sesion4
{
    public abstract class Pet
    {
        public string name;
        public int age;
        public double weight;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        { 
            get => age;
            set { 
                if (value < 0)
                {
                    throw new ArgumentException("tuoi k duoc am");
                }
                age = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can nang khong duoc am");
                }
                weight = value;
            }
        }
        public Pet(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Weight: {weight}");
        }

        public abstract void MakeSuond();
    }

    
}
