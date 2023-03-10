using System;

class Program {
  public static void Main (string[] args) {
  /*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
M = 4; N = 8. -> 30c

int InputNumber(string input)
{
     Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
 }

 void PrintSum(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     PrintSum(m, n - 1, sum);

 }
 int m = InputNumber("Ввод m: ");
 int n = InputNumber("Ввод n: ");
 int temp = m;

 if (m > n)
 {
     m = n;
     n = temp;
 }
 Console.Write($"{m}, {n} ->");
 PrintSum(m, n, temp = 0);*/ 

   /*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/

int InputNumber(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}
int Akkerman(int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if (n == 0 && m > 0)
{
return Akkerman(m - 1, 1);
}
else
{
return Akkerman(m - 1, Akkerman(m, n - 1));
}
}

int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int akkermanFunction = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");
    
  }
}