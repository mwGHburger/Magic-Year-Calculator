using System.Reflection.Emit;
namespace Magic_Year_Calculator
{
    public class Person
    {
        // CONSTRUCTOR
        public Person(string name, string surname, double annualSalary, int workStartYear)
        {
            this.Name = name;
            this.Surname = surname;
            this.AnnualSalary = annualSalary;
            this.workStartYear = workStartYear;
        }

        // PROPERTIES
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public double AnnualSalary { get; private set; }
        public int workStartYear { get; private set; }
    }
}