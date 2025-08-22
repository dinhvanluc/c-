
using System;
using System.Collections.Generic;
using T24098M.Bank;
using T24098M.Music;

namespace BankMusicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- BANK SYSTEM ---
            Console.WriteLine("=== Bank System ===");
            Console.Write("Enter amount for Normal Account: ");
            decimal normalAmount = decimal.Parse(Console.ReadLine());
            NormalAccount normalAcc = new NormalAccount(normalAmount);

            normalAcc.CheckBalance();
            normalAcc.Transfer(1_000_000);

            Console.WriteLine("\nExchange Account Example:");
            ExchangeAccount exchAcc = new ExchangeAccount(25000, 1000);
            exchAcc.CheckBalance();
            exchAcc.Transfer(1_000_000);

            // --- MUSIC SYSTEM ---
            Console.WriteLine("\n=== Music Store ===");
            List<Instrument> instruments = new List<Instrument>
            {
                new Guitar("Guitar Yamaha", 2020, 6),
                new Piano("Piano Roland", 2019, 88),
                new Guitar("Guitar Fender", 2021, 7),
                new Piano("Piano Yamaha", 2018, 76),
                new Guitar("Guitar Classic", 2017, 5)
            };

            foreach (var inst in instruments)
            {
                inst.ShowInfo();
                inst.Play();
            }
        }
    }
}
