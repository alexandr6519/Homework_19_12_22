// Задача 64: Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
try
{
    Console.WriteLine("Enter the natural number");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n < 1)
        Console.WriteLine("Enter positive numbers only!");
    else
    {
        Console.WriteLine($"The sequence of natural numbers from {n} to 1 is:");
        Console.WriteLine(GetSequence(n));
    }
}
catch
{
    Console.WriteLine("You should enter numbers only!");
}

string GetSequence(int n)
{
    if (n == 1) return n.ToString();
    return (n.ToString() + ", " + GetSequence(n - 1));
}
