// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Введите целое число. {userInformation} ");
    }
    return result;
}
double findDistanceTwoPoints3D(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
}

int userX1 = getCoordinateFromUser("Введите координату X1 = ");
int userY1 = getCoordinateFromUser("Введите координату Y1 = ");
int userZ1 = getCoordinateFromUser("Введите координату Z1 = ");
int userX2 = getCoordinateFromUser("Введите координату X2 = ");
int userY2 = getCoordinateFromUser("Введите координату Y2 = ");
int userZ2 = getCoordinateFromUser("Введите координату Z3 = ");
Console.Write("Расстояние между точками: ");
Console.Write(findDistanceTwoPoints3D(userX1, userY1, userZ1, userX2, userY2, userZ2));