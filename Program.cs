// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/* int size = Convert.ToInt32(20); // Пусть бюудет: 20
int minValue = 100;
int maxValue = 999;
int[] b = new int[size];
for (int i = 0; i < b.Length; ++i)
{
    b[i] = new Random().Next(minValue, maxValue + 1);
}
Console.WriteLine(string.Join(",", b));
int с = 0;
for (int i = 0; i < b.Length; i++)
{
    if (b[i] % 2 == 0)
        с += 1;
}
Console.Write($"количество чётных чисел в массиве : {с}"); */

//---------------------------------------------------------------------------------------
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/* int size = Convert.ToInt32(20); // Пусть бюудет: 20
int minValue = -100;
int maxValue = 100;
int[] b = new int[size];
int sum = 0;
for (int i = 0; i < b.Length; ++i)
{
    b[i] = new Random().Next(minValue, maxValue + 1);
    if (i % 2 != 0) sum += b[i];
}
Console.WriteLine(string.Join(",", b));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {sum}"); */

//---------------------------------------------------------------------------------------
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/* int size = 20; // Пусть бюудет: 20
double[] b = new double[size];
Random rand = new Random();
Console.WriteLine("Массив: ");
for (int i = 0; i < b.Length; ++i)
{
    b[i] = Math.Round((rand.NextDouble() * 10), 2);
    Console.Write(string.Join(",", b[i], " "));
}
double maxValue = b[0];
double minValue = b[0];
for (int i = 0; i < b.Length; ++i)
{
    if (maxValue < b[i]) maxValue = b[i];
    if (minValue > b[i]) minValue = b[i];
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива:");
Console.Write($"{maxValue} - {minValue} = {(maxValue - minValue)}"); */