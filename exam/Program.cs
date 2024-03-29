﻿//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//   При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//  Примеры:
//  [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//  [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//  [“Russia”, “Denmark”, “Kazan”] → []

using Microsoft.VisualBasic;

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}



Console.WriteLine("Введите размер первоначального массива: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите новый первоначальный массив: ");
string[] arr = new string[sizeOfArray];
for (int i = 0; i < sizeOfArray; i++)
{
    arr[i] = Console.ReadLine();
}

PrintArray(arr);
Console.WriteLine();

int countShortStrings = 0;
 foreach (string str in arr)
{
    if (str.Length <= 3)
    {
        countShortStrings++;
    }
}

string[] shortStringsArray = new string[countShortStrings];
int index = 0;
foreach (string str in arr)
{
    if (str.Length <= 3)
    {
        shortStringsArray[index++] = str;
    }
}

foreach (string shortString in shortStringsArray)
{
    Console.Write($"{shortString} ");
}