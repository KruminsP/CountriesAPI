namespace Countries.Core.Models;

public class ApiResponseCountry
{
    public Name name { get; set; }
    public List<string> Tld { get; set; }
    public List<string> Capital { get; set; }
    public double Area { get; set; }
    public int Population { get; set; }
}