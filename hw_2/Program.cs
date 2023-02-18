// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int GetThird(int val) {
    return val % 10;
}

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a > 99 && a < 1000) {
    Console.WriteLine(GetThird(a));
}
else {
    Console.WriteLine("Третьей цифры нет!");
}
