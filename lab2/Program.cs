try
{
    Console.WriteLine("Введите число для 1-го катета: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число для 2-го катета: ");
    int y = int.Parse(Console.ReadLine());
    double gip = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
    double S = 1 * x * y;
    Console.WriteLine($"Площадь S = {S}");
    Console.WriteLine($"Гипотенуза gip = {gip:F2}");
    
}
catch
{
    Console.WriteLine("Error");

    Console.WriteLine("");
}