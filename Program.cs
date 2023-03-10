Console.WriteLine("\nЗадание 1");
Max2 (5, 7);
Max2 (2, 10);
Max2 (-9, -3);
Console.WriteLine("\nЗадание 2");
Max3 (2, 3, 7);
Max3 (44, 5, 78);
Max3 (22, 3, 9);

Console.WriteLine("\nЗадание 3");
IsEven(4);
IsEven(-3);
IsEven(7);

Console.WriteLine("\nЗадание 4");
EvenNumbers(5);
EvenNumbers(8);


int Max2(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine(a + " больше " + b);
        return a;
    }

    Console.WriteLine(b + " больше " + a);
    return b;
}

int Max3(int a, int b, int c)
{
    if (a > b & a > c)
    {
        Console.WriteLine(a + " больше " + b + " и " + c);
        return a;
    }

    if (b > c)
    {
        Console.WriteLine(b + " больше " + a + " и " + c);
        return b;
    }

    Console.WriteLine(c + " больше " + a + " и " + b);
    return c;
}

bool IsEven(int n)
{
    if (n % 2 == 0)
    {
        Console.WriteLine("Число " + n + " четное");
        return true;
    }

    Console.WriteLine("Число " + n + " нечетное");
    return false;
}

int[] EvenNumbers(int n)
{
    int[] numbers = new int[n / 2];

    if (n % 2 != 0)
    {
        n--;
    }

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[numbers.Length - 1 - i] = n;
        n -= 2;
    }

    
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
    return numbers;
}