using LabaWS6;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(new RealShip().GetAllInfo());
        Console.WriteLine(new RealPlane().GetAllInfo());
        Console.WriteLine(new RealAuto().GetAllInfo());
    }
}