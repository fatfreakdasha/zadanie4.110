using System;

Console.WriteLine("введите масти карты (1-пики, 2- трефы, 3-бубны, 4-червы ");
int cardid = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер достоинства карты (11-валет , 12-дама , 13-король , 14-туз ");
int cardDignity = Convert.ToInt32(Console.ReadLine());
switch (cardDignity)
{
    case 6:
        Console.Write("шестерка"); break;
    case 7:
        Console.Write("семерка"); break;
    case 8:
        Console.Write("восьмерка"); break;
    case 9:
        Console.Write("девятка"); break;
    case 10:
        Console.Write("десятка"); break;
    case 11:
        Console.Write("валет"); break;
    case 12:
        Console.Write("дама"); break;
    case 13:
        Console.Write("король"); break;
    case 14:
        Console.Write("туз"); break;
}
switch (cardid)
{
    case 1:
        Console.Write(" пики"); break;
    case 2:
        Console.Write(" трефы"); break;
    case 3:
        Console.Write(" бубны"); break;
    case 4:
        Console.Write(" червы"); break;
}