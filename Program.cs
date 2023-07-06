// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// Например:
// a=5; b=7 -> max=7
// a=2; b=10 -> max=10
// a=-9; b=-3 -> max=-3


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number>number2)
{
    Console.WriteLine("max");
    Console.WriteLine(number);
    Console.WriteLine("min");
    Console.WriteLine(number2);
}
else  if (number<number2)
{
    Console.WriteLine("max");
    Console.WriteLine(number2);
    Console.WriteLine("min");
    Console.WriteLine(number);
}