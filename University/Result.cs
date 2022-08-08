using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal abstract class Result
    {
        public abstract string grade { get; }
        // public abstract string name { get; set; }

        public void Cgrade()
        {
            int num1, num2, num3, avg = 0;
            string grade;

            Console.WriteLine("---Student Marks Calculation Program in C#---\n");
            Console.Write("Enter #1 Grade: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter #2 Grade: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter #3 Grade: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 100 || num2 > 100 || num3 > 100) grade = "Error";
            else if (num1 < 0 || num2 < 0 || num3 < 0) grade = "Error";
            else
            {
                avg = (num1 + num2 + num3) / 3;

                if (avg > 100) grade = "Error";
                else if (avg < 0) grade = "Error";
                else if (avg > 90) grade = "A+";
                else if (avg > 70) grade = "B+";
                else if (avg > 50) grade = "C+";
                else if (avg > 30) grade = "C";
                else grade = "F";
                System.Console.Write("{0}\t{1}\t\n", avg, grade);
                Console.ReadLine();

            }
        }
    }

    }

