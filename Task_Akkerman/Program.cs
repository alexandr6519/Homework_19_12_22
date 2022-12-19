// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
try
{
    Console.WriteLine("Enter the positive number");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the positive number one more");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m < 1 || n < 1)
        Console.WriteLine("Enter positive numbers only!");
    else
    {
        Console.WriteLine("The result of calculate of Akkerman's function of numbers {0} and {1} is {2}", m, n, CalculateFunctionAkkerman(m, n));
        // PrintTable(array);
        // Console.WriteLine("This is array after sorting of rows:");
        // SortEachRowOfTableDescending(array);
        // PrintTable(array);
    }
}
catch
{
    Console.WriteLine("You should enter numbers only!");
}

int CalculateFunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return CalculateFunctionAkkerman(m - 1, 1);
    else return CalculateFunctionAkkerman(m - 1, CalculateFunctionAkkerman(m, n - 1));
}

