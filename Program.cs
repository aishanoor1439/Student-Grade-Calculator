using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Student_Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                //Input: Subjects for each student
                Console.WriteLine("Enter the number of subjects for the student:");
                int subjects = Convert.ToInt32(Console.ReadLine());

                double totalMarks = 0;

                //Input: Marks for each subject
                for (int i = 1; i <= subjects; i++)
                {
                    Console.WriteLine("Enter the marks for subject {0}:", i);
                    double marks = Convert.ToDouble(Console.ReadLine());
                    totalMarks += marks;
                }
                
                double avg = totalMarks / subjects;

                //Determine the grade
                char grade;
                if (avg >= 90)
                {
                    grade = 'A';
                }
                else if (avg >= 80)
                {
                    grade = 'B';
                }
                else if (avg >= 70)
                {
                    grade = 'C';
                }
                else if (avg >= 60)
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'F';
                }

                //Output
                Console.WriteLine("Grade: {0}", grade);

                //Ask if the user wants to continue
                Console.WriteLine("Do you want to continue?(y or n)");
                char response = Convert.ToChar(Console.ReadLine().ToLower());

                //Loop break
                if(response == 'n')
                {
                    break;
                }
            }
            Console.WriteLine("Thank you for using the program.");
        }
    }
}
