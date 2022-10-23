// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Polyndrom(int number){
// int first = number/10000;
// int second = (number/1000)%10;
// int fourth = (number/10)%10;
// int fiveth = number%10;
// if (first == fiveth & second == fourth)
//     {
//         Console.WriteLine($"Number {number} polyndrom");
//     } else {
//         Console.WriteLine($"Number {number} NOT polyndrom");
//     }
// }

// Console.WriteLine("Pls enter number N");
// int n = Convert.ToInt32(Console.ReadLine());
//     if (n>99999)
//     {
//         Console.WriteLine("Error input data");
//     }else{
//         Polyndrom(n);
//     }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125