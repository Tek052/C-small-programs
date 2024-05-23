using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Gradebook
{
    public class Program
    {
        public static void Main(string[] args)
        {


            //storing variables
            var listStudent = new List<String>();
            var gradeHomework = new List<double>();
            var gradeExam = new List<double>();
            string newStudent;
            
            //input student names
            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    listStudent.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in listStudent)
            {
                Console.WriteLine("Grade for homework " + student + ": ");
                double newGrade1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Grade for exam " + student + ": ");
                double newGrade2 = Int32.Parse(Console.ReadLine());
                gradeHomework.Add(newGrade1);
                gradeExam.Add(newGrade2);
            }

            //print student roasters
            for (int i = 0; i < listStudent.Count; i++)
            {

                {

                    Console.WriteLine(("The student ") + listStudent[i] + (" received the current marks:\nExam:") + gradeExam[i] + ("/100  Homework:") + gradeHomework[i] + ("/100"));
                    Console.WriteLine("===============================");
                }

            }


            //checking marks for further revisions
            Console.WriteLine("\nClass Revision :");
            for (int i = 0; i < listStudent.Count; i++)
                {

                    if (gradeExam[i] < 40 || gradeHomework[i] < 40)
                    {

                        Console.WriteLine(("The student ") + listStudent[i] + (" have not met the criteria and require further discussion at the examination board "));
                        Console.WriteLine("===============================");
                    }

                }


            //get class average
            Console.WriteLine("\nClass Average :");
            for (int i = 0; i < listStudent.Count; i++)
            {

                {

                    Console.Write(("The total marks average from the student ") + listStudent[i] + (" is:\t") + (gradeHomework[i] + gradeExam[i]) / 2 + ("%") + ("\n"));
                    Console.WriteLine("===============================");
                }

            }

            //get class student
            Console.WriteLine("\nClass marks :");
            for (int i = 0; i < listStudent.Count; i++)
            {
                if (gradeHomework[i] + gradeExam[i] / 2 >= 80)

                {

                    Console.WriteLine("===============================");
                    Console.WriteLine(("The student ") + listStudent[i] + (" has achivied the 1st Class! Congratulations! "));
                }

                else if (gradeHomework[i] + gradeExam[i] / 2 >= 70)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine(("The student ") + listStudent[i] + (" has achivied the Upper 2nd Class! Congratulations! "));

                }

                else if (gradeHomework[i] + gradeExam[i] / 2 >= 60)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine(("The student ") + listStudent[i] + (" has achivied the Lower 2nd Class! Congratulations! "));

                }

                else if (gradeHomework[i] + gradeExam[i] / 2 >= 40)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine(("The student ") + listStudent[i] + (" has achivied the Lower Third Class! Congratulations! "));

                }

                else
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine(("The student ") + listStudent[i] + (" has failed! Keep focus and try again! "));

                }

            }


            Console.ReadLine();
        }
    }
}