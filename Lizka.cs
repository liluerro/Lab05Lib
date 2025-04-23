using System;

namespace Lab05Lib
{
    public class Town
    {
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public int Population { get; set; }
        public double YearIncome { get; set; }
        public double Square { get; set; }
        public bool HasPort { get; set; }
        public bool HasAirport { get; set; }

        public double YearIncomePerInhabitant
        {
            get
            {
                return GetYearIncomePerInhabitant();
            }
        }

        public double GetYearIncomePerInhabitant()
        {
            return Population > 0 ? YearIncome / Population : 0;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.Write("Введiть кiлькiсть мiст: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int cntTowns) || cntTowns <= 0)
            {
                Console.WriteLine("Некоректне значення. Завершення програми.");
                return;
            }

            Town[] arrTowns = new Town[cntTowns];

            for (int i = 0; i < cntTowns; i++)
            {
                Console.Write("Введiть назву мiста: ");
                string? sName = Console.ReadLine() ?? string.Empty;

                Console.Write("Введiть назву краiни: ");
                string? sCountry = Console.ReadLine() ?? string.Empty;

                Console.Write("Введiть назву регiону: ");
                string? sRegion = Console.ReadLine() ?? string.Empty;

                Console.Write("Введiть кiлькiсть населення: ");
                string? sPopulation = Console.ReadLine();
                int population = int.TryParse(sPopulation, out int tempPopulation) ? tempPopulation : 0;

                Console.Write("Введiть рiчний дохiд: ");
                string? sYearIncome = Console.ReadLine();
                double yearIncome = double.TryParse(sYearIncome, out double tempYearIncome) ? tempYearIncome : 0;

                Console.Write("Введiть площу, кв. км: ");
                string? sSquare = Console.ReadLine();
                double square = double.TryParse(sSquare, out double tempSquare) ? tempSquare : 0;

                Console.Write("Чи є у мiстi порт? (y-так, n-нi): ");
                bool hasPort = Console.ReadKey().Key == ConsoleKey.Y;
                Console.WriteLine();

                Console.Write("Чи є у мiстi аеропорт? (y-так, n-нi): ");
                bool hasAirport = Console.ReadKey().Key == ConsoleKey.Y;
                Console.WriteLine();

                arrTowns[i] = new Town
                {
                    Name = sName,
                    Country = sCountry,
                    Region = sRegion,
                    Population = population,
                    YearIncome = yearIncome,
                    Square = square,
                    HasPort = hasPort,
                    HasAirport = hasAirport
                };
            }

            foreach (Town t in arrTowns)
            {
                Console.WriteLine();
                Console.WriteLine($"Данi про мiсто {t.Name}");
                Console.WriteLine($"Країна: {t.Country}");
                Console.WriteLine($"Регiон: {t.Region}");
                Console.WriteLine($"Кiлькiсть населення: {t.Population}");
                Console.WriteLine($"Рiчний дохiд: {t.YearIncome:0.00}");
                Console.WriteLine($"Площа: {t.Square:0.000}");
                Console.WriteLine(t.HasPort ? "У мiстi є порт" : "У мiстi нема порту");
                Console.WriteLine(t.HasAirport ? "У мiстi є аеропорт" : "У мiстi нема аеропорту");
                Console.WriteLine($"Середнiй рiчний дохiд на одного громадянина: {t.YearIncomePerInhabitant:0.00}");
            }

            Console.ReadKey();
        }
    }
}
