// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");

int pali = int.Parse(Console.ReadLine());
int result = FindPalindrom(pali);

if (result == 1) Console.WriteLine("Да!");
if (result == 2) Console.WriteLine("Нет!");

int FindPalindrom(int n)
{
    int begin = n / 1000;
    int end = (n % 10 * 10) + (n / 10 % 10); 

    if (begin == end)
    {
        return(1);
    }
    else return(2); 
}