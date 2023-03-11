// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите 1 число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if ( n > n2)
   Console.WriteLine($"max = {n}");
else
   Console.WriteLine($"max = {n2}");
