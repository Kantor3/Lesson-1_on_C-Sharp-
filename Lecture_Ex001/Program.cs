/* Тема Урока-2.
Использование функции (метода) в языке C#
*/

/*
Задача-1. Найти максимум из 9 чисел
*/

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 1457;
int c1 = 39;
int a2 = 21;
int b2 = 54816;
int c2 = 11;
int a3 = 264;
int b3 = 795;
int c3 = 17;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
