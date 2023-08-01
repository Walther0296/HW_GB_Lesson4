// Урок 4. Функции
Console.WriteLine("Урок 4. Функции");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Задание №1");
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Число " + A + " в степени " + B + " равно " + Math.Pow(A, B));
Console.WriteLine(String.Empty);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Задание №2");

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе {number} равна {SumAllDigit(number)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Задание №3");
int Prompt1(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result1 = int.Parse(ReadInput);
    return result1;
}

int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array; 
}

void PrintArray(int[] array)
{
    System.Console.Write(" [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("] ");
}

int length = Prompt1("Длина массива: ");
int min = Prompt1("Начальное значение, для диапазона случайного числа: ");
int max = Prompt1("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
