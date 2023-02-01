// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
//  а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите два числа: ");
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
int max = numA;
if (numB > max) max = numB;
Console.Write("max =");
Console.WriteLine(max);