using System;

class Task1
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 1 || number > 100)
            Console.WriteLine("Error");
        else if (number % 3 == 0 && number % 5 == 0)
            Console.WriteLine("Fizz Buzz");
        else if (number % 3 == 0)
            Console.WriteLine("Fizz");
        else if (number % 5 == 0)
            Console.WriteLine("Buzz");
        else
            Console.WriteLine(number);
    }
}

class Task2
{
    static void Main()
    {
        double number = Convert.ToDouble(Console.ReadLine());
        double percent = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(number * percent / 100);
    }
}

class Task3
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a * 1000 + b * 100 + c * 10 + d);
    }
}

class Task4
{
    static void Main()
    {
        string number = Console.ReadLine();

        if (number.Length != 6)
        {
            Console.WriteLine("Error");
            return;
        }

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        if (a < 1 || a > 6 || b < 1 || b > 6)
        {
            Console.WriteLine("Error");
            return;
        }

        char[] digits = number.ToCharArray();

        char temp = digits[a - 1];
        digits[a - 1] = digits[b - 1];
        digits[b - 1] = temp;

        Console.WriteLine(new string(digits));
    }
}

class Task5
{
    static void Main()
    {
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

        string season = "";

        if (date.Month == 12 || date.Month == 1 || date.Month == 2)
            season = "Winter";
        else if (date.Month >= 3 && date.Month <= 5)
            season = "Spring";
        else if (date.Month >= 6 && date.Month <= 8)
            season = "Summer";
        else
            season = "Autumn";

        Console.WriteLine(season + " " + date.DayOfWeek);
    }
}

class Task6
{
    static void Main()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (choice == 1)
            Console.WriteLine((temperature - 32) * 5 / 9);
        else if (choice == 2)
            Console.WriteLine(temperature * 9 / 5 + 32);
        else
            Console.WriteLine("Error");
    }
}

class Task7
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}

class Task8
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int temp = number;
        int count = number.ToString().Length;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, count);
            temp /= 10;
        }

        if (sum == number && number >= 0)
            Console.WriteLine("Armstrong number");
        else
            Console.WriteLine("Not an Armstrong number");
    }
}

class Task9
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                sum += i;
        }

        if (sum == number && number > 1)
            Console.WriteLine("Perfect number");
        else
            Console.WriteLine("Not a perfect number");
    }
}