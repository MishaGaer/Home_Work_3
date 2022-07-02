/* Напишите программу, 
которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result == 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
                break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

double GetQuarter(int xFirst, int yFirst, int zFirst, int xSecond, int ySecond, int zSecond)
{
    double result = Math.Sqrt(Math.Pow(xFirst - xSecond, 2) + Math.Pow(yFirst - ySecond, 2) + Math.Pow(zFirst - zSecond, 2));
    Console.WriteLine(result);
    return result;
}

int x1 = GetNumber("Введите значение x первой точки");
int y1 = GetNumber("Введите значение y первой точки");
int z1 = GetNumber("Введите значение z первой точки");
int x2 = GetNumber("Введите значение x второй точки");
int y2 = GetNumber("Введите значение y второй точки");
int z2 = GetNumber("Введите значение z второй точки");

GetQuarter(x1, y1, z1, x2, y2, z2);
