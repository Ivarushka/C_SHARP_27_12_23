// 2. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Enter a number 1: ");
int a1 = int.Parse(Console.ReadLine()!);
int count = -a1;
while (count <= a1)
{
    Console.Write(count+" ");
    count++;
}
