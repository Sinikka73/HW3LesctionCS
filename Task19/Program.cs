// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int(); 
    result = new Random().Next(minBorder, maxBorder); 
    return result;
}

int randomNumber = getRandomNumberFromRange(34543, 34544);

int number = randomNumber;
int reversNumber = 0;
    while(number > 0)
    {
        int digit = number%10;
        reversNumber = reversNumber*10 + digit;
        number = number / 10;
    }
    if(reversNumber == randomNumber) Console.WriteLine($"Число {randomNumber} является палиндромом");
    else Console.WriteLine($"Число {randomNumber} не является палиндромом");
