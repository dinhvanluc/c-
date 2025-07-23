using System;
using System.Collections.Generic;
using T24098M.sesion4;

public class PetStore
{
    private List<Pet> pets = new List<Pet>();

    public void AddPet(Pet pet)
    {
        pets.Add(pet);
    }

    public void ShowAllPets()
    {
        Console.WriteLine("\n--- Danh sách thú cưng ---");
        foreach (var pet in pets)
        {
            pet.ShowInfo();
            Console.WriteLine();
        }
    }

    public void MakeAllPetsSound()
    {
        Console.WriteLine("\n--- Tiếng kêu của thú cưng ---");
        foreach (var pet in pets)
        {
            pet.MakeSuond();
        }
    }
}
