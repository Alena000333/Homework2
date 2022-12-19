//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
 

int WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("выходной день  ");
        }
        else
        {
            Console.Write("рабочий день  ");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return a;
}


Console.WriteLine("Введите число от 1 до 7:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(WorkHoliday(x));


