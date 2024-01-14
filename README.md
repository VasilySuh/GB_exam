# Описание:
Экзаменационная работа представляет собой пример кода на C#, который позволяет вводить массив строк с клавиатуры, выводить его на экран, и создавать новый массив, содержащий только строки с длиной менее или равной 3.

# Использование:
## Ввод размера и первоначального массива:
* Запустите приложение.
* Введите размер первоначального массива.
* Введите строки первоначального массива.
``` C#
Console.WriteLine("Введите размер первоначального массива: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите новый первоначальный массив: ");

string[] arr = new string[sizeOfArray];
for (int i = 0; i < sizeOfArray; i++)
{
    arr[i] = Console.ReadLine();
}
```
## Вывод первоначального массива:
* Используйте метод PrintArray для вывода первоначального массива на экран.
``` C#
PrintArray(arr);
Console.WriteLine();
```
## Создание нового массива с короткими строками:
* Используйте цикл для подсчета коротких строк.
* Создайте новый массив shortStringsArray.
* Выведите новый массив коротких строк на экран.
``` C#
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
```