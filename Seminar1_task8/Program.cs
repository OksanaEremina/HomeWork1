//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine ("Введите число : ");
long number1 = Convert.ToInt64(Console.ReadLine());
for (int i = 1; i <= number1; i+=1) {
    if (i % 2 == 0) {
        Console.Write (i + ", ");
    }
}
