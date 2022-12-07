namespace Countries.Core.Models;

public class CountryWithoutName
{
    public CountryWithoutName(double area, int population, IEnumerable<string> tld, IEnumerable<string> capital)
    {
        Area = area;
        Population = population;
        Tld = tld.First();
        Capital = capital.First();
    }
    public double Area { get; set; }
    public int Population { get; set; }
    public string Tld { get; set; }
    public string Capital { get; set; }
}