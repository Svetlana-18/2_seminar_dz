// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1   

Console.WriteLine("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int NumberSearch(int num)
    {
        int secondten = num % 100;
        int secondtdigit = (secondten - num % 10) / 10;
        return secondtdigit;
    }
    int result = NumberSearch(number);
    Console.WriteLine($"вторая цифра числа {number} -> {result}");
}
else Console.WriteLine("вы ввели не трехзначное число, повторите ввод");