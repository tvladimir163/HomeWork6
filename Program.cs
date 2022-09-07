// Console.Clear();


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write($"Введи размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];

for (int i = 0; i < m; i++)
{
    Console.Write($"Введи {i + 1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count += 1;
}

Console.Write($"в массиве [{string.Join(", ", array)}] {count} цифр больше 0");



// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// // значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("введите значение b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("введите значение k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("введите значение b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("введите значение k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"точка пересечения двух прямых Х: {x}, Y: {y}");