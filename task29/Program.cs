//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//  6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.Write("Введите числа, согласно размеру масива: ");
for (int i = 0; i < array.Length; i++)
{
  array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");