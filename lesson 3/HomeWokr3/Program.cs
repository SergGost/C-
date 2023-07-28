// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом(первое == последнему, второе == предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"Ошибка!{number} - не является пятизначным");
// }
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Введите X координаты точки А: ");
// int coordAX = int.Parse(Console.ReadLine()!);
// Console.Write("Введите Y координаты точки А: ");
// int coordAY = int.Parse(Console.ReadLine()!);
// Console.Write("Введите Z координаты точки А: ");
// int coordAZ = int.Parse(Console.ReadLine()!);
// Console.Write("Введите X координаты точки B: ");
// int coordBX = int.Parse(Console.ReadLine()!);
// Console.Write("Введите Y координаты точки B: ");
// int coordBY = int.Parse(Console.ReadLine()!);
// Console.Write("Введите Z координаты точки B: ");
// int coordBZ = int.Parse(Console.ReadLine()!);
// double ABZ = Math.Sqrt(Math.Pow((coordBX - coordAX),2) + Math.Pow((coordBY - coordAY),2) + Math.Pow((coordBZ - coordAZ),2));
// Console.WriteLine ($"{ABZ:f2}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число ");
// int K = int.Parse(Console.ReadLine()!);
// int N = 1;
// while(N <= K){
//     Console.Write($"{Math.Pow(N, 3)}, ");
//     N ++;
// }
