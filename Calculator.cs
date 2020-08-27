namespace Magic_Year_Calculator
{
    public class Calculator
    {
        // METHODS
        public static double CalculateMonthlySalaryOf(Person person)
        {
            return person.AnnualSalary / 12;
        }

        public static int CalculateMagicYearOf(Person person)
        {
            return person.workStartYear + 65;
        }
    }
}