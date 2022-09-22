using Reading_File_Using_LINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        String File = "C:\\Users\\user\\source\\repos\\Countries Demo App\\Country.Csv ";
        CsvReader reader = new CsvReader(File);
        List<Country> countries = reader.ReadFirstNCountry();
        
        //display first three countries
        Console.WriteLine("display first three countries");
        foreach (Country country in countries.Take(3))
        {
            Console.WriteLine(country.Name);    
        }
        foreach (Country country in countries.Take(3))
        {
            Console.WriteLine(country.Name);
        }
        Console.WriteLine("\n");
        //display population order by name
        Console.WriteLine("display population order by name ");
        foreach (Country country in countries.OrderBy(x=>x.Name))
        {
            Console.WriteLine($"{country.Name}     :    {country.population}");
        }
        //display first three population order by name
        Console.WriteLine("display first three population order by name ");
        foreach (Country country in countries.OrderBy(x => x.Name).Take(3))
        {
            Console.WriteLine($"{country.Name}     :    {country.population}");
        }
        //display first 12 population 
        Console.WriteLine("display first 12 population order by name and remove country contain comma");
        var filteredCountries = countries.Take(13).Where(x => x.Name.Contains(','));
        foreach (Country country in filteredCountries)
        {
            Console.WriteLine($"{country.Name}     :    {country.population}");
        }
        var filteredCountries2 = from country in countries
                                 where country.Name.Contains(',')
                                 select country;
        foreach(Country country in filteredCountries2)
        {
            Console.WriteLine($"{country.Name}     :    {country.population}");
        }
    }
}