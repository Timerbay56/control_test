class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',').Select(s => s.Trim()).ToArray();
        string[] outputArray = FilterShortStrings(inputArray);
        Console.WriteLine("Новый массив из строк, длина которых <= 3 символам: [" + string.Join(", ", outputArray) + "]");
    }

    static string[] FilterShortStrings(string[] inputArray)
    {
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] outputArray = new string[count];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                outputArray[index++] = str;
            }
        }

        return outputArray;
    }
}