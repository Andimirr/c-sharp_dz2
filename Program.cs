// Задача 10: Напишите программу, которая принимает на вход трёхзначное
//  число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int digitBacklight(int day)
// {
//     int sot = day / 100;
//     int ed = day % 10;
//     return(( day - (sot*100 + ed))/10);
// }

// int randomnum = new Random().Next(100, 1000);
// //randomnum = 918;
// Console.WriteLine(randomnum);
// Console.WriteLine(digitBacklight (randomnum));

// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int Handrets(int day)
// {
//     int sot =  (day / 100 % 10);
//     return sot;
// }

// int randomnum = new Random().Next(10, 10000);
// randomnum = 21;
// Console.WriteLine(randomnum);
// if (randomnum <= 99)
//     Console.Write($"Третьей цифры нет: {Handrets(randomnum)}");
// else
//     Console.WriteLine(Handrets(randomnum));


// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// string DayOf(int num)
// {
//     if (num >= 1 && num <= 5)
//         return "no";
//     else
//         return "yes";
// }

// int randomnum = new Random().Next(1, 8);
// Console.WriteLine(randomnum);
// Console.WriteLine(DayOf(randomnum));
