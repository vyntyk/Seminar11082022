﻿/*Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние 
между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите х1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2 - x1)* (x2 - x1)  + (y2 - y1)*(y2 - y1));
result = Math.Round(result, 2);
Console.WriteLine(result);
