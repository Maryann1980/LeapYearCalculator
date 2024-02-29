namespace LeapYearCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Next 20 Leap Years:");


            // Get the current year
            int currentYear = DateTime.Now.Year;

            // Calculate and display the next 20 leap years
            for (int i = 0; i < 20; i++)
            {
                int nextLeapYear = GetNextLeapYear(currentYear);
                Console.WriteLine(nextLeapYear);
                currentYear = nextLeapYear + 1; // Move to the next year
            }

            Console.ReadLine(); // Keep console window open
        }

        static int GetNextLeapYear(int currentYear)
        {
            // Loop until a leap year is found
            while (true)
            {
                // Check if the current year is a leap year
                if (DateTime.IsLeapYear(currentYear))
                {
                    return currentYear;
                }

                // Move to the next year
                currentYear++;
            }
        }
    }
}
