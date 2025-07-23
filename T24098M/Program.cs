// See https://aka.ms/new-console-template for more information
using T24098M.sesion4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        PetStore store = new PetStore();
        Dog dog = new Dog("Buddy", 3, 20.5, true);
        Cat cat = new Cat("da da ", 2, 5.0, "vang");
        Bird bird = new Bird("dai bang", 1, 0.5, "cau vong");

        store.AddPet(dog);
        store.AddPet(cat);
        store.AddPet(bird);
        store.ShowAllPets();
        store.MakeAllPetsSound();
    }
}