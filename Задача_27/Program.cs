/*Задача 27: Напишите программу, которая принимает на вход число и
 выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine( "Введите число: ");
int Number = int.Parse(Console.ReadLine());

int sum = 0;
if (Number < 10) Console.WriteLine("Введите большее число!!");
do
{
    sum =sum + Number%10;
    Number = Number/10;
}

while (Number>0); Console.WriteLine(sum);











