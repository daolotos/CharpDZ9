Console.WriteLine("вычисления функции Аккермана:");
int m = ReadInt("m = ");
int n = ReadInt("n = ");

int a = Acermann(m, n);

Console.WriteLine($"A({m},{n}) = {a}");

// m и n - перепутаны местами. Реализация функции как в википедии, ввод чисел как в задании
int Acermann(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (m == 0)
        return Acermann(n - 1, 1);
    return Acermann(n - 1, Acermann(n, m - 1));
}

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

