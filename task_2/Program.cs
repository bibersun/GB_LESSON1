//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 > num1)
{
    Console.WriteLine("Второе больше первого");
}
else if (num2 < num1)
{
    Console.WriteLine("Первое больше второго");
}
else
{
    Console.WriteLine("Равны");
}
