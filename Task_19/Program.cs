/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

//Первый вариант решения

System.Console.WriteLine("Введите пятизначное число: ");
string? num = Console.ReadLine();

if (num!.Length == 5)
    if (num[0] == num[4] && num[1] == num[3])
    {
        System.Console.WriteLine("Данное число ЯВЛЯЕТСЯ палиндромом!");
    }
    else
    {
        System.Console.WriteLine("Данное число НЕ является палиндромом!");
    }
else
{
    System.Console.WriteLine("Некорректное число! Введите пятизначное число.");
}

//Второй (математический) вариант решения

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    if (number/10000 == number%10 && (number/1000)%10 == (number%100)/10)
    {
        System.Console.WriteLine("Данное число ЯВЛЯЕТСЯ палиндромом!");
    }
    else
    {
        System.Console.WriteLine("Данное число НЕ является палиндромом!");
    }
}
else
{
    System.Console.WriteLine("Некорректное число! Введите пятизначное число.");
}