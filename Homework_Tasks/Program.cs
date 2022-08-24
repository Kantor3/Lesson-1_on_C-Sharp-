/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
            и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
----------------------------------------------------------------------------------------

//-------------------------------
int CheckNumber(string str)
//-------------------------------
{
    if (!Int32.TryParse(str, out int number))
    {
        number = -1;
        Console.WriteLine($"Введенная строка '{str}' не являются числом\nПопробуйте еще раз, или '0' для выхода");
    }
    return number;
}

//-------------------------------
bool CheckExit(int num)
//-------------------------------
{
    if (num == 0)
    {
        Console.WriteLine("\nРабота с программой завершена, До встречи!\n");
        return true;
    }
    return false;
}

//-------------------------------
void GetSymbol(string str, int number_symbol)
//-------------------------------
{
    Console.WriteLine($"Введено число {str}. '{str[number_symbol-1]}' -> {number_symbol}-я цифра этого числа");
}

// Осночное тело программы
// =======================
Console.WriteLine("Введите любое трехзначное целое число, для завершения введите '0':");
Console.WriteLine("---");
while (true)
{
    string? str_number = Convert.ToString(Console.ReadLine());
    int number = CheckNumber(str_number);
    if (number < 0)
        continue;
    if (CheckExit(number))
        break;
    GetSymbol(str_number, 2);    // получить и вывести 2-й символ переданной строки  
}
// *** Конец Задачи 10 ***
*/


/*
Задача 13: Напишите программу, которая выводит третью цифру 
            заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
----------------------------------------------------------------------------------------

//-------------------------------
int CheckNumber_plus(string str)
//-------------------------------
{
    if (!Int32.TryParse(str, out int number))
    {
        number = -1;
        Console.WriteLine($"Введенная строка '{str}' не являются числом\nПопробуйте еще раз, или '0' для выхода");
    }
    else if (number == 0)
        Console.WriteLine("\nРабота с программой завершена, До встречи!\n");
     return number;
}

//-------------------------------
void GetSymbol(string str, int number_symbol)
//-------------------------------
{
    if (str.Length < 3)
        Console.WriteLine($"Введено число {str} -> третьей цифры НЕТ");
    else
        Console.WriteLine($"Введено число {str}. '{str[number_symbol-1]}' -> {number_symbol}-я цифра этого числа");
}

// Осночное тело программы
// =======================
Console.WriteLine("Введите любое целое число. Я покажу 3-ю цифру, для завершения введите '0':");
Console.WriteLine("---");
while (true)
{
    string? str_number = Convert.ToString(Console.ReadLine());
    int number = CheckNumber_plus(str_number);
    if (number == 0)
        break;
    else if (number < 0)
        continue;
    else
        GetSymbol(str_number, 3);    // получить и вывести 3-й символ переданной строки  
}        
// *** Конец Задачи 13 ***
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
            обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
----------------------------------------------------------------------------------------

//-------------------------------
int Check_dayWeek(string str)
//-------------------------------
{
    if (!Int32.TryParse(str, out int dayW))
    {
        dayW = -1;
        Console.WriteLine($"Введенная строка '{str}' не являются числом\nПопробуйте еще раз, или '0' для выхода");
    }
    else if (dayW == 0)
        Console.WriteLine("\nРабота с программой завершена, До встречи!\n");
    else if (dayW < 1 || dayW > 7)
    {
        dayW = -1;
        Console.WriteLine($"Введенное число {str} не является днем недели. Введите число от 1 до 7");
    }
    return dayW;
}

//-------------------------------
string GetWeekend(int dayW)
//-------------------------------
{
    string result = dayW > 5 ? "выходной" : "НЕ выходной";
    return result;
}

// Осночное тело программы
// =======================
Console.WriteLine("Введите день недели. Для завершения введите '0':");
Console.WriteLine("---");
while (true)
{
    string? str_dayWeek = Convert.ToString(Console.ReadLine());
    int dayWeek = Check_dayWeek(str_dayWeek);
    if (dayWeek == 0)
        break;
    else if (dayWeek < 0)
        continue;
    else
        Console.WriteLine($"День недели {dayWeek} - {GetWeekend(dayWeek)}");
}
// *** Конец Задачи 15 ***
*/