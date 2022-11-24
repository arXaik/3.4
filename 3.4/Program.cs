// Петросян Араик 22-ИСП-2/1 3.4 средний уровень
double A = -Math.PI / 5;
double B = 9 * Math.PI / 5;
double H = 0.2;
Console.WriteLine("Введите x:");
double x = Convert.ToDouble(Console.ReadLine());
double y;
if (x > 2.5)
{
    while (A <= B)
    {
        y = Math.Sin(2.3 * x - 1);
        Console.WriteLine("F( {0} ) = {1}", A, y);
        A += H;
    }
}
if (0 <= x && x <= 2.5)
{
    while (A <= B)
    {
        y = 1 - 3 * Math.Log10(Math.Abs(1 - x));
        Console.WriteLine("F( {0} ) = {1}", A, y);
        A += H;
    }
}
if (x < 0)
{
    while (A <= B)
    {
        y = 2 - x;
        Console.WriteLine("F( {0} ) = {1}", A, y);
        A += H;
    }
}