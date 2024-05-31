using System;

namespace Projectg
{
 class Program
    {
        static void Main(string[] args)
        {

            int addgrade;
            int grade;
            double sum = 0;
            double average;

            Console.WriteLine("Enter many attemp grade:");
            addgrade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < addgrade; i++)
            {
                Console.Write("Enter the Grade:");
                grade = Convert.ToInt32(Console.ReadLine());
                sum = sum + grade;
            }
            average = sum / addgrade;

             if (average <= 50)
            {
                Console.WriteLine(average + " Failed");
            }
            else if (average <= 70)
            {
                Console.WriteLine(average + " Fair");
            }
            else if (average <= 80)
            {
                Console.WriteLine(average + " Good");
            }
            else if (average <= 90)
            {
                Console.WriteLine(average + " Very Good");
            }
            else
            {
                Console.WriteLine(average + " Excellent");
            }

            Console.WriteLine("Total Grade you input: " + sum);

        }
        
    }

}