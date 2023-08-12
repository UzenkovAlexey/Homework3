/*
Задача 2: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/

Console.Write("Enter number: ");
int Num = Convert.ToInt32(Console.ReadLine());

int leng = Length(Num);

Console.Write($"Сумма цифр числа {Num} = {Sum(Num,leng)}");

int Length(int Num)
{
    int result = 0;
    while (Num > 0)
    {
         Num /= 10;
         result++;
    }
    return result;
}   
int Sum(int Num, int leng)
{
    int sum = 0;
    for (int i = 1; i <= leng; i++)
    {
      sum += Num % 10;
      Num /= 10;
    }
    return sum;
}