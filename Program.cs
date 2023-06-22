//Задача 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Seknd(int n) {
    if (n > 99 && n < 1000)
    {
        Console.WriteLine("Вторая цифра " + (n % 100)/10);
    }
    else
    {
        Console.WriteLine("Ошибка, вы ввели не трехзначное число");
    }
}
Seknd(num);




/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 645 -> 5
 78 -> третьей цифры нет
 32679 -> 6 */

int num = new Random().Next(1,100000);
Console.WriteLine("Ваше число " + num);

int i = 100;

if (num > 99)
{
    while (num / i > 9)
        {
        i = i*10;
        }
    Console.WriteLine( "Третья цифра - " + (num % (i/10)) / (i/100) );
}
else
{
    Console.WriteLine("Третьей цифры нет");
}




/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Weeknd (int n) {

    if (num >= 1 && num <= 7)
    {
        if (num > 5)
            {
            Console.WriteLine("Выходной!");
            }
        else
            {
            Console.WriteLine("Давай работай)");
            } 
    }
    else
    {
        Console.WriteLine("Ошибка");    
    }
}

Weeknd(num);
