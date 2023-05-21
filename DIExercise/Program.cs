using System;

namespace DIExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var loan = new Loan();
            
            Console.Out.WriteLine("Podaj imię i nazwisko:");
            string name = Console.ReadLine();

            Console.Out.WriteLine("Podaj pesel:");
            string pesel = Console.ReadLine();

            Console.Out.WriteLine("Podaj rok urodzenia:");
            string birthYearStr = Console.ReadLine();

            Console.Out.WriteLine("Podaj zarobki:");
            string salaryStr = Console.ReadLine();

            Console.Out.WriteLine("Podaj kwotę pożyczki:");
            string requestedLoanAmountStr = Console.ReadLine();
            
            loan.Get(name,pesel,birthYearStr,salaryStr,requestedLoanAmountStr);
        }
    }
}
