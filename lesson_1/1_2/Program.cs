Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a>b)
{
    Console.Write("Первое число больше второго");
    }
else if (a < b)
            {
                Console.WriteLine("Первое число меньше второго");
            }
else {
    Console.Write("Оба числа равны");
}