// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

int GetSecond(int val) {
    return (val%100)/10;
}

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSecond(a));
