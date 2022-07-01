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
//метод проверки на полиндром
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

/*
//метод проверки числа
char[] GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        string messageStr = Console.ReadLine();

        if (int.TryParse(messageStr, out int number))
        {
            if (number > 9999 && number < 100000)
            {
                char[] message2 = messageStr.ToCharArray();
                return message2;
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
}

//Метод проверки на полиндром

string CheckNumber(char[] value)
{
    int length = value.Length;
    string otvet = " ";
  
    for (int i =  0; i<length; i++)
    {
    if (value[i] == value[length-1-i])
    {
        otvet = "Введенное число является полиндромом!";
    }
        else
        {
            otvet = "Введенное число не является полиндромом!";
            break;
        }
    }
    Console.WriteLine(otvet);
    return otvet;
}

//Основной

char[] massage = GetNumber("Введите пятизначное число");
CheckNumber(massage);
*/
/*
//метод считывания массива чаров
string CheckNumber(char[] value)
{
    int length = value.Length;
    string otvet = " ";
  
    for (int i =  0; i<length; i++)
    {
    if (value[i] == value[length-1-i])
    {
        otvet = "Введенное слово или число является полиндромом!";
    }
        else
        {
            otvet = "Введенное слово или число НЕ является полиндромом!";
            break;
        }
    }
    Console.WriteLine(otvet);
    return otvet;
}

//Основной

Console.WriteLine("Введите слово или число");

string messageStr = Console.ReadLine();
char[] message2 = messageStr.ToCharArray();
CheckNumber(message2);
*/
