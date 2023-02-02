// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;

int num2 = num / 10;
int num3 = num2 % 10;

Console.WriteLine(num3);

if(num3==num3)
{
int num4 = num3 / 100;
int num5 =num4 % 10;
Console.WriteLine(num3);
}