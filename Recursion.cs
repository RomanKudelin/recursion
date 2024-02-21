// //                        ЗАДАЧА № 1




// class NaturalNumbersPrinter
// {
//     static void PrintNaturalNumbersRecursion(int M, int N)
//     {
//         if (M <= N)
//         {
//             Console.WriteLine(M);
//             PrintNaturalNumbersRecursion(M + 1, N);
//         }
//     }

//     static void Main()
//     {
//         Console.Write("Введите начальное число: ");
//         int M = int.Parse(Console.ReadLine()!);

//         Console.Write("Введите конечное число: ");
//         int N = int.Parse(Console.ReadLine()!);

//         PrintNaturalNumbersRecursion(M, N);
//     }
// }



//                      ЗАДАЧА № 2



// class AckermannFunctionCalculator
// {
//     static int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         else
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
//     }

//     static void Main()
//     {
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine()!);

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine()!);

//         int result = AckermannFunction(m, n);
//         Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {result}");
//     }
// }


//                       ЗАДАЧА № 3



class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int j)
    {
        if (j >= 0)
        {
            Console.Write(array[j] + " ");
            PrintArrayReversed(array, j - 1);
        }
    }
}