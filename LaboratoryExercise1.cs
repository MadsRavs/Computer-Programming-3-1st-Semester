namespace GreetingApp{
    class GreetingProgram{
        static void Main(string[]args){
            //variable declaration
            string name;
            int no_Course;
            double price;
            //Input for student name
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Beep();
            //Input for Number of courses enrolled
            Console.WriteLine("Enter the total number of enrolled courses: ");
            no_Course = int.Parse(Console.ReadLine());
            Console.Beep();
            //Input for book price
            Console.WriteLine("Enter the price your favourite book: ");
            price = double.Parse(Console.ReadLine());
            Console.Beep();
            //output 
            string output = $"Name: {name}\nTotal enrolled courses: {no_Course}\nPrice of my favorite book: {price}\n\nPress any key to exit...";
            Typings(output);
            Console.ReadKey();
            Console.Beep();
        }

         static void Typings(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(40); //delay
            }
        }
    }
}