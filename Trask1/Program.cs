Console.Write("Введите целые числа через пробел: ");
string[] arrayM = Console.ReadLine().Split().ToArray();

int[] resultM = new int[arrayM.Length];

ExceptionHandling(arrayM);
int countM = GetCountNumbers(resultM);
string str = "числа";
if (countM > 4 || countM == 0) str = "чисел";
else if (countM == 1) str = "число";
PrintInputUser(resultM);
Console.Write($"-> {countM} {str} больше нуля");

int GetCountNumbers(int[] num)
{
    int length = num.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (num[i] > 0) count++;
    }
    return count;
}

void PrintInputUser(int[] arrayString)
{
    string stringArray = " ";

    for (int i = 0; i < arrayString.Length; i++)
    {
        stringArray += $"{arrayString[i]}, ";
    }
    int n = stringArray.Length;
    stringArray = stringArray.Remove(n - 2, 2);
    stringArray += " ";
    Console.Write($"{stringArray}");
}

void ExceptionHandling(string[] numbers)
{
    int length = numbers.Length;
    bool yesInt;
    for (int i = 0; i < length; i++)
    {
        yesInt = int.TryParse(numbers[i], out int result);
        if (yesInt)
        {
            resultM[i] = result;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("<{0}>", numbers[i]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" -> Некорректный ввод!");
        }
    }
}
