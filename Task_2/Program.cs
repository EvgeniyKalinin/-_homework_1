Console.WriteLine("Введите 3 числа (Через enter)");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;
if (b > max)
{
    max = b;
}
if (b < min) 
{
    min = b;
}
if (c > max)
{
    max = c;
}
if (c < min) 
{
    min = c;
}
Console.WriteLine("Максимальное число " + max + ".");
Console.WriteLine($"Минимальное число {min}.");