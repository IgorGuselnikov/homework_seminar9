// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int AkkermannFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0) return secondNumber + 1;
    if (firstNumber > 0 && secondNumber == 0) return AkkermannFunction(firstNumber - 1, 1);
    return AkkermannFunction(firstNumber - 1, AkkermannFunction(firstNumber, secondNumber - 1));
}

Console.WriteLine($"Значение функции Аккермана с параметрами ({M}, {N}) равно: {AkkermannFunction(M,N)}");
