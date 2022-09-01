

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine ("Введите число a: ");
long number1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine ("Введите число b: ");
long number2 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine ("Введите число c: ");
long number3 = Convert.ToInt64(Console.ReadLine());
long max = number1;
if (max < number2) {
    max = number2;
}
if (max < number3) {
    max = number3;
}
Console.WriteLine(max);
