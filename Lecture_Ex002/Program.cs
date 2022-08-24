/* Тема Урока-2.
Использование функции (метода) в языке C#
*/

/*
Задача-1. Найти максимум из 9 чисел, используя массив
*/

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

int[] array = { 17, 21, 34, 4, 57, 63, 27, 82, 39 };
int result1 = array[0];
int result2 = result1;

// вариант использования цикла-1
for (int i = 1; i < array.Length; i++)
    if (array[i] > result1) result1 = array[i];

// вариант использования цикла-2
foreach (int el in array)
    if (el > result2) result2 = el;

Console.WriteLine(result1);
Console.WriteLine(result2);