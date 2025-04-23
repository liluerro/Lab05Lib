class Town
{
    public string Name; public string Country; public string Region; public int
    Population; public double YearIncome; public double Square; public bool HasPort;
    public bool HasAirport;

    public double GetYearIncomePerInhabitant()
    {
        return YearIncome / Population;
    }
    static void Main(string[] args)
    {
        Console.Write("Введiть назву мiста: "); string sName = Console.ReadLine();

        Console.Write("Введiть назву краiни: "); string sCountry = Console.ReadLine();

        Console.Write("Введiть назву регiону: "); string sRegion = Console.ReadLine();

        Console.Write("Введiть кiлькiсть населення: "); string sPopulation = Console.ReadLine();

        Console.Write("Введiть рiчний дохiд: "); string sYearIncome = Console.ReadLine();

        Console.Write("Введiть площу, кв. км: "); string sSquare = Console.ReadLine();

        Console.Write("Чи є у мiстi порт? (y-так, n-нi): "); ConsoleKeyInfo keyHasPort = Console.ReadKey(); Console.WriteLine();

        Console.Write("Чи є у мiстi аеропорт? (y-так, n-нi): "); ConsoleKeyInfo keyHasAirport = Console.ReadKey(); Console.WriteLine();

        Town OurTown = new Town();

        OurTown.Name = sName; OurTown.Country = sCountry; OurTown.Region = sRegion;
        OurTown.Population = int.Parse(sPopulation); OurTown.YearIncome = double.Parse(sYearIncome); OurTown.Square = double.Parse(sSquare);
        OurTown.HasPort = keyHasPort.Key == ConsoleKey.Y ? true : false;
        OurTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y ? true : false;

        double YearIncomePerInhabitant = OurTown.GetYearIncomePerInhabitant();
        Console.WriteLine();
        Console.WriteLine(" ");
        Console.WriteLine("Данi про об'єкт:");
        Console.WriteLine("Назва: " + OurTown.Name);
        Console.WriteLine("Країна: " + OurTown.Country);
        Console.WriteLine("Регiон: " + OurTown.Region);
        Console.WriteLine("Кiлькiсть населення: " + OurTown.Population.ToString());
        Console.WriteLine("Рiчний дохiд: " + OurTown.YearIncome.ToString("0.00"));
        Console.WriteLine("Площа: " + OurTown.Square.ToString("0.000"));
        Console.WriteLine(OurTown.HasPort ? "У мiстi є порт" : "У мiстi нема порту");
        Console.WriteLine(OurTown.HasAirport ? "У мiстi є аеропорт" : "У мiстi нема аеропорту");
        Console.WriteLine();
        Console.WriteLine("Середнiй рiчний дохiд на одного мешканця: " + YearIncomePerInhabitant.ToString("0.00"));
    }
}
