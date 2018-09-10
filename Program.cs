using System;
using System.Collections.Generic;
using System.Linq;

namespace change_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = Console.ReadLine();
            var change = Decimal.Parse(amount);

            var currencies = new List<Currency> {
                new Currency {Name = "hundred", Value = 100.00m, Count = 0},
                new Currency {Name = "fifty", Value = 50.00m, Count = 0},
                new Currency {Name = "twenty", Value = 20.00m, Count = 0},
                new Currency {Name = "ten", Value = 10.00m, Count = 0},
                new Currency {Name = "five", Value = 5.00m, Count = 0},
                new Currency {Name = "dollar", Value = 1.00m, Count = 0},
                new Currency {Name = "quarter", Value = 0.25m, Count = 0},
                new Currency {Name = "dime", Value = 0.10m, Count = 0},
                new Currency {Name = "nickel", Value = 0.05m, Count = 0},
                new Currency {Name = "penny", Value = 0.01m, Count = 0}
            };

            foreach (var currency in currencies)
            {
                currency.Count = (int) (change / currency.Value);

                Console.WriteLine(currency.Count);

                change -= currency.Count * currency.Value;
            }

            Console.WriteLine("[{0}]", string.Join(" ", currencies.Select(c => c.Count)));
        }
    }

    public class Currency
    {
        public string Name { get; set; }

        public decimal Value { get; set; }

        public int Count { get; set; }
    }
}
