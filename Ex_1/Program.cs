// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");

int pali = int.Parse(Console.ReadLine());

int begin = pali / 1000;
int end = (pali % 10 * 10) + (pali / 10 % 10);

if (begin == end) 
{
Console.WriteLine("Да!");
}
else Console.WriteLine("Нет!");