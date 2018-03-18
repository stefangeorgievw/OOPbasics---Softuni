using System;


public class Program
{
    static void Main(string[] args)
    {
        var lenght = decimal.Parse(Console.ReadLine());
        var width = decimal.Parse(Console.ReadLine());
        var height = decimal.Parse(Console.ReadLine());
        try
        {
            var box = new Box(lenght, width, height);

            decimal surfaceArea = 0;
            decimal lateralSurfaceArea = 0;
            decimal volume = 0;
            surfaceArea = box.CalculateSurfaceArea(lenght, width, height);
            lateralSurfaceArea = box.CalculateLateralSurfaceArea(lenght, width, height);
            volume = box.CalculateVolume(lenght, width, height);

            Console.WriteLine($"Surface Area - {surfaceArea:F2}");
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:F2}");
            Console.WriteLine($"Volume - {volume:F2}");
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine(ex.Message);
        }
        



    }
}

