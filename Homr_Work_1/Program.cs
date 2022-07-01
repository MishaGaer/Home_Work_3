/*Напишите программу, 
которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

// Методы

//метод проверки введенного числа
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 9999 && number < 100000)
            {
                return number;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не верное число.Число должно быть пятизначным!");
            }

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }

    }

    return result;
}

void CheckNumber(int value)
{
    int reverse = 0;
    int remainder = 0;
    int value1 = value;
    while (value > 0)
    {
        remainder = value % 10;
        reverse = reverse * 10 + remainder;
        value = value / 10;
    }
    if (value1 == reverse)
    {
        Console.WriteLine("Введенное число является полиндромом!");
    }
    else
    {
        Console.WriteLine("Введенное число НЕ является полиндромом!");
    }
}

//Основной

int palindrome = GetNumber("Введите пятизначное число");
CheckNumber(palindrome);
