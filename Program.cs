namespace LeapYear;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the year:");
            int year;
            int.TryParse(Console.ReadLine(), out year);
            if (year % 4 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("Its a leap year");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine("Its not a leap year");
                }
                else
                {
                    Console.WriteLine("Its a leap year");
                }
            }
            else
            {
                Console.WriteLine("Its not a leap year");
            }
        }
        catch
        {
            Console.WriteLine("Error! Please try again later.");
        }
    }
}
