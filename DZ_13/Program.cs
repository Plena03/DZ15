//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine ("Введите число: ");
string? numberString = Console.ReadLine ();
var number=  int.Parse (numberString!);

if (number > 10000 && number < 100000)
{
    number = (number % 1000) / 100;
    Console.WriteLine("Выводим третью цифру этого числа:");
    Console.WriteLine(number);
}
else if (number > 1000 && number < 10000)
{
    number = (number % 100) / 10;
    Console.WriteLine("Выводим третью цифру этого числа:");
    Console.WriteLine(number);
}
else if (number > 100 && number < 1000)
{
    number = number % 10;
    Console.WriteLine("Выводим третью цифру этого числа:");
    Console.WriteLine(number);
} 

else if (number < 100)
Console.WriteLine("Третьей цифры нет!");