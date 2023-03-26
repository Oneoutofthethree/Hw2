Console.WriteLine("Введите число:");

int a = int.Parse(Console.ReadLine());
if(a<100)
{
    Console.WriteLine("Введите число ,более чем двухзначное.");
}
if(a<1000 & a>99)
{
    int result = a%10;
    Console.WriteLine(result);
}
while (a>999)
{
    a = a/10;
        if (a<1000)
        {
            int result = a%10;
            Console.WriteLine(result);
        }
}