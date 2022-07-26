// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SummaryDigits(int firstNumber, int lastNumber)
{
    if (firstNumber == lastNumber) return lastNumber;
    return firstNumber + SummaryDigits(firstNumber + 1, lastNumber);
}

Console.WriteLine($"Сумма чисел от {M} до {N} равна: {SummaryDigits(M,N)}");