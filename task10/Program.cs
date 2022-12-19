//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int Number ( int num )
{
int a = num/10 ;
int b = a%10 ;
return b ;
}

Console.WriteLine("Введите трехзначное число:");
int x = Convert.ToInt32(Console.ReadLine());
int result = Number(x);
Console.WriteLine($"Вторая цифра этого числа = { result } ");
