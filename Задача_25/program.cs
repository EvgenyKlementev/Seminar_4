// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

 
  Console.Write("Введите numberA   : ");
  int A = int.Parse(Console.ReadLine());

  Console.Write("Введите numberB : ");
  int B = int.Parse(Console.ReadLine());
  
  int result=1;
  for(int i = 0; i < B; i++) 
  {
   result *= A;
  }
  Console.WriteLine($"Число {A} в степени {B} = {result}");
  
 
  