public class Motorcycle : Vehicle
{
    public string Type { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Bike Type: {Type}");
    }
}
