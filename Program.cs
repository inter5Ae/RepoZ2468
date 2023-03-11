// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Clear();
Console.Write("Введите 1 число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int maxi = n;

if (n2 > maxi)
    maxi = n2;
if (n3 > maxi)
   maxi = n3;

Console.WriteLine($"max = {maxi}");

