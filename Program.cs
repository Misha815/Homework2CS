//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/* Console.WriteLine("Введите число:");

void Convert(int number)
{
    int result; 
    result = (number/10)%10;
    Console.WriteLine(result);
}

int input = int.Parse(Console.ReadLine());
Convert(input); */


//Задание 13 Напишите программу, которая выводит третью цифру заданного числа или сообщеает, что третьей цифры нет.
    
    /* Console.WriteLine("Введите число:");

void ThridNumber(int number)
    {
    if (number > 100)
{
int result;
result = number % 10;
        Console.WriteLine(result);
}
    else if (number <100) Console.WriteLine("третьей цифры не существует:");
   }

    int num = Convert.ToInt32(Console.ReadLine());
    ThridNumber(num); */

//Задание 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

/* Console.WriteLine("Введите день недели");

int Weekend(int num)
{
    int Saturday  = 6;
    int Sunday  = 7;
       if (num == Saturday  || num == Sunday ) Console.WriteLine("Выходные");
       
       else Console.WriteLine("Рабочие дни");
             
       if (num > 7 ) Console.WriteLine("Это не дни недели");

    return num;
}
int q = Convert.ToInt32(Console.ReadLine());

int res = Weekend(q);

Console.WriteLine(res); */


