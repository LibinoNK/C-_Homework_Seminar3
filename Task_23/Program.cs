/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

System.Console.WriteLine("Введите число (N): ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{   
    for (int i = 1; i <= N; i++)
    {
        double num = Math.Pow(i, 3);
        System.Console.WriteLine($"Число {i} в квадрате равно {num}");
    }
}
else
{
    System.Console.WriteLine("Некорректное число! Введите число больше 0!");
}