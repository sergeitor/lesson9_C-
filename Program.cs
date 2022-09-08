//  Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// т.к. разбирали на занятии, её не нужно делать.




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Необходимо ввести числа от M до N!");

Console.WriteLine("Введите число M:");

int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");

int N = Convert.ToInt32(Console.ReadLine());

 

int GetSum(int m,int n)
{
   int sum = m;

   if(m >= n)
        {
           return  sum;
        }

   return  sum += GetSum(m+1,n);
}

Console.WriteLine("Сумма элементов равна: " + GetSum(M,N));


//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число m:");

int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n:");

int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
            {
                if (m == 0) return n + 1;
                if (m != 0 && n == 0) return Akkerman(m - 1, 1);
                if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
                return Akkerman(m,n);
            }


Console.WriteLine("Результат: " + Akkerman(m,n));           











  




























