// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите B: ");
// int b = int.Parse(Console.ReadLine()!);
//  int result = 1;

//  for(int i = 1; i <= b; i++){
//      result = result * a;
// }

// Console.WriteLine(result);







// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Введите ваше число: ");
// int a = int.Parse(Console.ReadLine()!);
// int sum = 0;
// while (a > 0)
//         {
//             int number = a % 10;
//             a = a / 10;
//             sum += number;
//         }
        
//Console.WriteLine("Сумма всех цифр в числе равна " + sum); 






// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Console.Write("Введите числа из массива: ");
// string seriesOfNumbers = Console.ReadLine();





// int[] array = GetRange(8);
// Console.WriteLine($"[{String.Join(",", array)}]");


// int[] GetRange(int size){
//     int[] massive = new int[size];
//     for(int i = 0; i < massive.Length; i++){
//         massive[i] = new Random().Next(2);
//     }
//     return massive;
//}