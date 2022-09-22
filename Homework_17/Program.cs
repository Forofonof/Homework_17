using System;

internal class Program
{
    static void Main(string[] args)
    {
        const char LeftBracket = '(';
        int rightBracketsCount = 0;
        int leftBracketsCount = 0;
        int maxDepth = 0;
        int currentDepth = 0;
        bool isCorrect = true;

        Console.WriteLine("Введите скобочное выражение: ");
        string userInput = Console.ReadLine();

        foreach (var symbol in userInput)
        {
            if (symbol == LeftBracket)
            {
                currentDepth++;
                leftBracketsCount++;
            }
            else 
            {
                currentDepth--;
                rightBracketsCount++;
            }

            if (currentDepth >= maxDepth)
            {
                maxDepth = currentDepth;
            }

            if (currentDepth < 0)
            {
                isCorrect = false;
            }
        }

        if (leftBracketsCount != rightBracketsCount)
        {
            isCorrect = false;
        }

        if (isCorrect)
        {
            Console.WriteLine($" {userInput} - Строка корректная и максимум глубины равняется: {maxDepth}.");
        }
        else
        {
            Console.WriteLine("Строка некорректная.");
        }
    }
}