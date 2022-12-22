Console.WriteLine("Вывод чисел от N до 1:");

int N = ReadInt("N = ");

PrintRecursive(N);

void PrintRecursive(int n)
{
    Console.Write($"{n} ");
    if (n > 1)
        PrintRecursive(n - 1);
}

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

