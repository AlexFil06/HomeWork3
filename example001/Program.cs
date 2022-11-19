// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число  ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int numb)
{
    return numb / 10000 == numb % 10 && (numb / 1000) % 10 == (numb % 100) / 10;   // возможно тут намудрил, есть ли способ проще?
}



if (number > -99999 && number < 99999)
{
    bool result = Palindrome(number);
    Console.Write($"{number} -> ");
    Console.WriteLine(result ? "Да" : "Нет");
}
else
{
    Console.WriteLine("Число не пятизначное");
}


