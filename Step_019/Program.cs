﻿
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Число {number} - Палиндром.");
  }
  else Console.WriteLine($"Число {number} - НЕ ПАЛИНДРОМ.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Некорректный ввод числа");