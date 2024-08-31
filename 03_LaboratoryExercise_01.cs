using System;
using System.Globalization;
using System.Threading;

namespace StudentGradeApplication{
    class frmStudentGradeProgram{
        // array declaration sa labas para maaccess ng mga methods
        static double[] grades = new double[5];
        //main method where I can call the methods
        static void Main(string[] args){
            //local variables store called methods
            string name = GetStudentName();
            Console.WriteLine("==============================");
            InputGrades();
            Console.WriteLine("==============================");
            //calling the sum method and taking the average
            double computeSum = ComputeSum();
            double computeAverage = computeSum/grades.Length;
            //rounding off average
            double convertedAve = Math.Round(computeAverage);
            string PorF = convertedAve >= 75 ? "PASSED" : "FAILED";
            //output
            string output = $"\nThe average grade of {name} is {computeAverage:F2} and rounded off to {convertedAve}, \nwhich means you {PorF}\nPress any key to exit..";
            Typings(output);
            Console.ReadKey();
            Console.Beep();
        }

        // student name method
        static string GetStudentName(){
            Console.Write("Enter the name of the student: ");
            return Console.ReadLine();
        }

        // Grades input method
        static void InputGrades(){
            for (int i = 0; i < grades.Length; i++){
                string subject = i switch{
                    0 => "Math",
                    1 => "Science",
                    2 => "History",
                    3 => "Physics",
                    4 => "Computer Programming",
                    _ => "Unknown"
                };
                //with input validation
                bool validInput = false;
                while (!validInput){
                    Console.Write($"Enter the grade for {subject}: ");
                    if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double grade)){
                        grades[i] = grade;
                        validInput = true;
                    }
                    else{
                        Console.Write("Invalid input.\n");
                    }
                }
            }
        }
        // Sum of all grades method
        static double ComputeSum(){
            double sum = 0;
            foreach (double x in grades){
                sum += x;
            }
            return sum;
        }
        // Wala lang ule para mema cool effect typings 
        static void Typings(string text){
            foreach (char c in text){
                Console.Write(c);
                Thread.Sleep(30); 
            }
        }
    }
}
