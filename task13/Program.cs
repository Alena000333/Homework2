//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
      
      
        int Number(int num)
        {
            int result = -1;
            if (num >= 100)
            {
                while (num > 999)
                {
                  num = num / 10;
                  Console.WriteLine("Число имеет больше трех цифр");  
                }
                result = num % 10;
            }
           else
            {
                Console.WriteLine("Третьей цифры нет");
            }
            return result;
        }

Console.WriteLine("Введите трехзначное число:");
int x = Convert.ToInt32(Console.ReadLine());
int result = Number(x);
Console.WriteLine($"Третья цифра этого числа = { result } ");