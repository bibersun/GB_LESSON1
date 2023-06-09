/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N */
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num1)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}
