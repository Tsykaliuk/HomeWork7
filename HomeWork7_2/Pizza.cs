namespace Builder;

public class Pizza
{
    private string? dough;
    private string? sauce;
    private string? topping;

    public void SetDough(string d) => dough = d;
    public void SetSauce(string s) => sauce = s;
    public void SetTopping(string t) => topping = t;

    public void Info()
    {
        Console.WriteLine("Dough: {0}\nSauce: {1}\nTopping: {2}", dough, sauce, topping);
    }
}
