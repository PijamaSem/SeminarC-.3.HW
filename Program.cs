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

// double Distance (int xa, int ya, int za, int xb, int yb, int zb){
//     double dist=Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(za-zb)*(za-zb));
//     return dist;
// }
// Console.WriteLine("Pls enter number xa");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Pls enter number ya");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Pls enter number za");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Pls enter number xb");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Pls enter number yb");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Pls enter number zb");
// int zb = Convert.ToInt32(Console.ReadLine());

// double dist = Distance(xa,ya, za, xb, yb,zb);
// Console.WriteLine($"Length is {Math.Round(dist,2)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void TableOfCube(int n){
//     for(int i=1; i<=n; i++){
//         Console.Write($"{i*i*i} ");
//     }
// }
// Console.WriteLine("Pls enter number N");
// int x = Convert.ToInt32(Console.ReadLine());
// TableOfCube(x);
