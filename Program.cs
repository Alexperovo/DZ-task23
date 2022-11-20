// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double [n];
double num = 0;
foreach(double i in numbers){num++;
Console.WriteLine(Math.Pow(num,3));
}