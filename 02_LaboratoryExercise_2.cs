using System.Diagnostics.Contracts;
using System.Reflection;
namespace ComputerAverageApp{
    class ComputerAverageProgram{
        static void Main(string[]args){
            //varable declaration and initialization of computeSum
            double computeAverage;
            double computeSum=0;
            //user input stored in an array for cleaner look and for loop to access the array elements
            Console.WriteLine("Enter 5 grades separated by new line: ");
            int[] grades = new int[5];
            for (int i=0;i<grades.Length;i++){
                grades[i] = int.Parse(Console.ReadLine());
                Console.Beep();
            }
            //Another for loop to now add all the numbers of the arrays and a nested if statement to compute for the average once the last index has been accessed
            for (int i=0;i<grades.Length;i++){
                computeSum += grades[i];
                if(i==4){
                    computeAverage = computeSum/5;
                    double convertedAve = Math.Round(computeAverage);
                    string output = $"The average is {computeAverage} and round off to {convertedAve}\nPress any key to exit...";
                    Typings(output);
                    Console.Beep();
                }
            }
            Console.ReadKey();
        }
         //Wala lang para cool typings
         static void Typings(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50); //delay
            }
        }
    }
}