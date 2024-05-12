using System;

namespace Project_g
{
    internal class Program
    {
      static void Main(string[] args)
        {
            
            double addg, average;
            int attempg;
            

            Console.WriteLine("Enter how many grade you want to compute:");
            attempg = int.Parse(Console.ReadLine());
            double sum = 0;


            while (attempg > 0)
            {
                Console.WriteLine("Enter you're grade:");
                addg = double.Parse(Console.ReadLine());
                sum += addg;
                attempg--;

                Console.WriteLine("The total grade:" + sum);
                average = sum / attempg;
                if (average <= 50)
                {
                    
                    Console.WriteLine(average+ "Failed");
                }
                else if (average <= 70)
                {
                   
                    Console.WriteLine(average+ "Fair");
                }
                else if (average <= 80)
                {
                   
                    Console.WriteLine(average+ "Good");
                }
                else if (average <= 90)
                {
                    
                    Console.WriteLine( average+ "Very Good");
                }
                else
                {
                    
                    Console.WriteLine(average +"Excelent");

                }
            }
        }
    }
}
