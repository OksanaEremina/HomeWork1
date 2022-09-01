

//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine ("Введите число a: ");
long number1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine ("Введите число b: ");
long number2 = Convert.ToInt64(Console.ReadLine());
long max = number1;
if (number1 < number2) {
    max = number2;
}
Console.WriteLine($"max = {max}");
