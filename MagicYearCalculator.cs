using System;

namespace Magic_Year_Calculator
{
    public class MagicYearCalculator
    {
        // STATIC METHODS
        public static void Run()
        {
            Person person = createPerson();
            MagicYearCalculator.DisplayResults(person);
        }

        private static Person createPerson()
        {
            Display("Please input your name: ");
            string name = Console.ReadLine();
            Display("Please input your surname: ");
            string surname = Console.ReadLine();
            Display("Please enter your annual salary: ");
            double annualSalary = Convert.ToDouble(Console.ReadLine());
            Display("Please enter your work start year: ");
            int workStartYear = Convert.ToInt32(Console.ReadLine());

            return new Person(name, surname, annualSalary, workStartYear);
        }

        private static void DisplayResults(Person person)
        {
            Display("\nYour magic age details are: \n");
            Display($"Name: {person.Name} {person.Surname}");
            Display($"Monthly Salary: {Math.Round(Calculator.CalculateMonthlySalaryOf(person))}");
            Display($"Magic Year: {Calculator.CalculateMagicYearOf(person)}");
        }

        private static void Display(string text)
        {
            Console.WriteLine(text);
        }
    }
}