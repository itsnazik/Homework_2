// Напишите программу,которая принимает на вход цифру, которая обозначает день недели, и проверяет, является ли это день выходным

int WeekDays(int number) {
    if(number >= 1 && number <= 5) {
    Console.WriteLine("Нет, это не выходной день!");
    }
    else if(number == 6 || number == 7) {
    Console.WriteLine("Да, это выходной день!");
    }
    else {
    Console.WriteLine("Такого дня нет, введите правильное число");
    } 
    return 0;
}

Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(WeekDays(day));
