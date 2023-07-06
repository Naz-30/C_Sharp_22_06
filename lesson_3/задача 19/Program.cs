void Pali(int num)
{
    int num1=num/1000;
    int num2=num%10;
    int num3=num/10%10;

    if(num1==num2*10+num3)
        Console.WriteLine($"Yes, {num} is a palindrome");
    else
        Console.WriteLine($"No, {num} is not a palindrome");
}
Console.WriteLine("Enter a five-digit number");
int val=int.Parse(Console.ReadLine()!);
Pali(val);
