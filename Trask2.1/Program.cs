﻿string[] enteredValues = GetFillArray();
var count = ExceptionHandling(enteredValues);
if (count.ex)
{
    double x = (count.arr[3] - count.arr[2]) / (count.arr[0] - count.arr[1]);
    double y = ((count.arr[3] * count.arr[0]) - (count.arr[2] * count.arr[1])) / (count.arr[0] - count.arr[1]);
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($" x = {x:F1}; y = {y:F1} ");
    Console.BackgroundColor = ConsoleColor.Black;

}
else
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" -> Некорректный ввод!");
}

string[] GetFillArray()
{
    string[] array = new string[4];
    int length = array.Length;
    string namePoint = "K1";
    for (int i = 0; i < length; i++)
    {
        if(i < 2)
        {
            namePoint = $"K{i + 1}";
        }
        else namePoint = $"B{i - 1}";
        Console.Write($"Введите число для {namePoint}: ");
        array[i] = Console.ReadLine().Replace(".", ","); // Replace добавил после 8 семинара.
    }
    return array;
}

(bool ex, double[] arr) ExceptionHandling(string[] array)
{
    double[] arrayDouble = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        bool yesDouble = double.TryParse(array[i], out double d);
        if (!yesDouble)
        {
            return (false, arrayDouble);
        }
        else arrayDouble[i] = d;
    }
    return (true, arrayDouble);
}