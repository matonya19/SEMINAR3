// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите число");
string number  = Console.ReadLine();
if (number[0] == number[4] || number[1] == number[3])
{
    Console.WriteLine("Это число палиндром");
}
else {
    Console.WriteLine("Это число не палиндром");
}






//Задача 21. Напишите программу, которая принимает на вход координаты 2-х точек и находит расстояние между ними в 3D пространстве 

// int[]point = new int[6];
// Console.WriteLine("Введите x1: ");
// point[0] = Convert.ToInt32(Console.ReadLine());                                                        
// Console.WriteLine("Введите y1: ");
// point[1] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1: ");
// point[2] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// point[3] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// point[4] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1: ");
// point[5] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Sqrt(Math.Pow(point[3]-point[0],2) + Math.Pow(point[4]-point[1],2) + Math.Pow(point[5]-point[2],2)));


// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= N; i++)
// {
//     Console.WriteLine(i*i*i);
// }

