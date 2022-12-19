// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
try
{
    Console.WriteLine("Enter the natural number");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter another the natural number");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m < 1 || n < 1)
        Console.WriteLine("Enter positive numbers only!");
    else if (m > n) (m, n) = (n, m);
    Console.WriteLine($"The sum of natural numbers from {m} to {n} is {GetSumNumbers(m, n)}");
}
catch
{
    Console.WriteLine("You should enter numbers only!");
}

int GetSumNumbers(int m, int n)
{
    if (n == m) return m;
    return (n + GetSumNumbers(m, n - 1));
}
