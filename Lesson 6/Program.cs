// //Напишите программу, которая перевернёт одномерный массив 
// //(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] result = ReverseArray2(array);
// Console.WriteLine(String.Join(" ", result));

// ReverseArray1(array);
// Console.WriteLine(String.Join(" ", array));


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// // Первый метод
// void ReverseArray1(int[] array){
//     for(int i = 0; i < array.Length / 2; i++){
//         int k = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = k;
//     }
// }

// // Второй метод
// int[] ReverseArray2(int[] array){
//     int[] result = new int[array.Length];
//     for(int i = 0; i < array.Length; i++){
//         result[i] = array[array.Length - i - 1];
//     }
//     return result;
// }

// //Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// //Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите первую сторону Вашего треугольника: ");
// int first = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите вторую сторону Вашего треугольника: ");
// int second = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третью сторону Вашего треугольника: ");
// int third = int.Parse(Console.ReadLine()!);

// if(trianglecheck(first, second, third)) Console.WriteLine("Ваш треугольник возможен в евклидовой системе координат");
// else Console.WriteLine("Ваш треугольник не возможен в евклидовой системе координат");

// //method
// bool trianglecheck(int first, int second, int third){
//     if((first + second > third) && (first + third > second) && (second+ third > first)) return true;
//     return false;
// }