//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("Введите число (день недели): ");
string? numberString = Console.ReadLine ();
var number=  int.Parse (numberString!);

if (number < 6 )
{
    Console.WriteLine("Рабочий день недели.");
}
else if (number == 6)
{
    Console.WriteLine("Выходной день!");
    Console.WriteLine("СУББОТА!");
} 

else if (number == 7)
{
    Console.WriteLine("Выходной день!");
    Console.WriteLine("ВОСКРЕСЕНЬЕ!");
}

else if (number > 7)
{
    Console.WriteLine("Введен не правильный день недели!!!");
    Console.WriteLine("В неделе 7 дней, а не " + number);
}
