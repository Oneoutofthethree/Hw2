Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

if (a>7|a<1)
{
    Console.WriteLine("Введенное не является номером дня недели.");
}
if(a==7|a==6)
    {
        Console.WriteLine("Выходной");
    }