// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(number));
int SumNumbers(int number)
{
  int sum = 0;
  while (number != 0)
  {
    int lastDigit = number % 10;
    sum = sum + lastDigit;
    number = number / 10;
  }
  return (sum);
}