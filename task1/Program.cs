// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 10 == 0) Console.WriteLine("Это НЕ палиндром");

int rightPart = number % 100;
int leftPart = number / 1000;
int rightReverse = (rightPart % 10 * 10) + (rightPart / 10);

if (rightReverse == leftPart) Console.WriteLine("Это палиндром");
else Console.WriteLine("Это НЕ палиндром");
