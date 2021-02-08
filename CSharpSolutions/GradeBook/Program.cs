using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Gradebook = new Dictionary<string, string>();
            Console.WriteLine("Enter a students name or quit");
            string Studentname = Console.ReadLine().ToLower();
            while (Studentname!="quit")
            {
                Console.WriteLine("Enter the student's grades");
                string Studentgrades = Console.ReadLine();
                Gradebook.Add(Studentname, Studentgrades);
                Console.WriteLine("Enter another students name or quit");
                Studentname = Console.ReadLine();
            }

            int lowestgrade;
            int highestgrade;
            double averagegrade;

            foreach (string student in Gradebook.Keys)
            {
                int[] grades;
                grades = Array.ConvertAll<string, int>(Gradebook[student].Split(), Convert.ToInt32);
                lowestgrade = grades.Min();
                highestgrade = grades.Max();
                averagegrade = grades.Average();
                Console.WriteLine(student + " ");
                Console.WriteLine("The Lowest Grade is " + lowestgrade);
                Console.WriteLine("The highest Grade is " + highestgrade);
                Console.WriteLine("The average Grade is " + averagegrade);
                
            }
      
        }
    }
}
