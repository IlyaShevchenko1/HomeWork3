﻿// Third Homework

//Task 19. Напишите программу, которая принимает на вход ЛЮБОЕ число и 
//проверяет, является ли оно палиндромом.

/* 
bool CompareFirstAndLast (string number)
{
    int lenght = number.Length;
    int index = 0;
    int lastIndex = lenght - 1;
    int a = 0;

    while (number[index] == number[lastIndex] && index < lenght / 2)
    {
        a = a + 1;
        index++;
        lastIndex--;
    }
    if (a == lenght / 2) return true;
    else return false;    
}
 
Console.Write("Input a number: ");
string number = Console.ReadLine();

bool res = CompareFirstAndLast(number);
if (res == true) Console.Write($"Number {number} is a palindrome");
else Console.Write($"Number {number} is not a palindrome");

*/

//Task 21. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

/*

double DistanceTwoPoints (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) +
    Math.Pow(z2 - z1, 2)), 2);
    return distance;
}

Console.Write("Input a coodinate x of the first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a coodinate y of the first point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a coodinate z of the first point: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a coodinate x of the second point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a coodinate y of the second point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a coodinate z of the second point: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = DistanceTwoPoints(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Distance between points ({x1};{y1};{z1}) and ({x2};{y2};{z2}) is {distance}");

*/

//Task 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу
//кубов чисел от 1 до N.

/*
void CubeNumber (int number)
{
    int current = 1;
    int cube = 0;

    while (current <= number)
    {
        cube = current * current * current;
        Console.WriteLine($"{current} --> {cube}");
        current++;
    }
}

Console.Write("Input a number: ");
int cube = Convert.ToInt32(Console.ReadLine());

CubeNumber(cube);
*/


