// 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите A: ");
//  int first = int.Parse(Console.ReadLine()!);
//  Console.Write("Введите B: ");
//  int second = int.Parse(Console.ReadLine()!);
 
//  if (first > second)
// {
//     Console.WriteLine("A больше B");  
// }
// else
// {
//     if (first < second)
//     {
//         Console.WriteLine("B больше A");
//     }
//     else
//     {
//         Console.WriteLine("A равно B");
//     }
// }

// 2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите A: ");
// int first = int.Parse(Console.ReadLine()!);
// Console.Write("Введите B: ");
// int second = int.Parse(Console.ReadLine()!);
// Console.Write("Введите C: ");
// int third = int.Parse(Console.ReadLine()!);

// int max = first;
// if (max < second)
// {
//     max = second;
// }
// if (max < third)
// {
//     max = third;
// }
// Console.WriteLine($"Максимальное число = {max}");

// 3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number%2==0)
// {
//     Console.WriteLine("Число четное");
// }
// else
// {
//     Console.WriteLine("Число нечетное");  
// } 

// 4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

int i = 1;
while(i < N)
{
    if(i % 2 == 0 )
    {
        Console.Write($"{i} ");
    }
    i++;
}
Console.WriteLine();
