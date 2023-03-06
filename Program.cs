// Задача 10: Напишите программу, которая принимает на вход трёхзначное
//  число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int digitBacklight(int num)
{
    int sot = num / 100;
    int ed = num % 10;
    return((num - (sot*100 + ed))/10);
}

int randomnum = new Random().Next(100, 1000);
randomnum = 918;
Console.WriteLine(randomnum);
Console.WriteLine(digitBacklight (randomnum));
