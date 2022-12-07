namespace Countries.Core.Models;

public class Country
{
    public Country(string name, double area, int population, IEnumerable<string> tld, string nativeName, IEnumerable<string> capital)
    {
        Name = name;
        Area = area;
        Population = population;
        Tld = tld.First();
        NativeName = nativeName;
        Capital = capital.First();
    }
    public string Name { get; set; }
    public double Area { get; set; }
    public int Population { get; set; }
    public string Tld { get; set; }
    public string NativeName { get; set; }
    public string Capital { get; set; }
}