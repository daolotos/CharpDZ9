
int M = ReadInt("M = ");
int N = ReadInt("N = ");

int summ = SummRecursive(M, N);

Console.WriteLine($"Сумма чисел от {M} до {N}: {summ}");

int SummRecursive(int m, int n)
{
    if (m > n)
        return 0;
    return m + SummRecursive(m + 1, n);
}

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

