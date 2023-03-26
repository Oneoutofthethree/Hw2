Console.WriteLine("Введите число:");
int a= int.Parse(Console.ReadLine());
if (a>99 & a<1000)
{
    int result = a/10%10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введено не трехзначное число.");
}