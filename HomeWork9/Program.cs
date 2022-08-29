/*
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowwNum(int m, int n)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if (n != m) ShowwNum(m, n - 1);
    Console.Write(n + " ");
}
Console.Write(" Натуральные числа от: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($" Натуральные числа от {m} до : ");
int n = Convert.ToInt32(Console.ReadLine());
ShowwNum(m, n);

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumElements(int m, int n)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
 int result = 0;
    if (m!= n) return result+= m + SumElements(m+ 1, n );
    return 0;
}
Console.Write("Сумма натуральных числа от: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных чисел от {m} до : ");
int n = Convert.ToInt32(Console.ReadLine());
 Console.Write($"Сумма элементов от {m} до {n} = {SumElements(m,n)}");
*/
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akkermana(int m, int n)
{
    if (m == 0) return n + 1;
    if (  n == 0) return Akkermana(m - 1, 1);
    if (m > 0 && n > 0) return Akkermana(m - 1, Akkermana(m, n - 1));
    return 0;
   
}
Console.Write("input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Akkermana(m, n));
