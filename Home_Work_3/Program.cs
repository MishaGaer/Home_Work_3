/*
Напишите программу, 
которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// Метод провери
int CheckStr(string message, string error)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        {
            Console.WriteLine(error);
        }

    }
}
//Метод для вывода кубов
void GetCube(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
    Console.Write(Math.Pow(number, 3));
}
//Основной код
string message = "Введите число.";
string error = "Вы ввели не число. Введите пожалуйста корректное число.";
int number = CheckStr(message, error);
GetCube(number);