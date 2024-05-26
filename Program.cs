using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строки через пробел (или нажмите Enter для использования примера):");
        string input = Console.ReadLine();

        string[] array;
        if (string.IsNullOrEmpty(input))
        {
            array = new string[] { "Hello", "2", "world", "", ":-)" };
            Console.WriteLine("Используется пример: " + string.Join(", ", array));
        }
        else
        {
            array = input.Split(' ');
        }

        string[] filteredArray = FilterArrayByLength(array, 3);

        Console.WriteLine("\nОтфильтрованный массив:");
        if (filteredArray.Length == 0)
        {
            Console.WriteLine("Нет строк длиной менее 4 символов.");
        }
        else
        {
            foreach (string str in filteredArray)
            {
                Console.WriteLine(str);
            }
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static string[] FilterArrayByLength(string[] array, int maxLength)
    {
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= maxLength)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= maxLength)
            {
                filteredArray[index] = str;
                index++;
            }
        }

        return filteredArray;
    }
}