using System;

namespace Magic_Year_Calculator
{
    public class MagicYearCalculator
    {
        public static void Run()
        {
            Person person = createPerson();
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

        private static void Display(string text)
        {
            Console.WriteLine(text);
        }
    }
}