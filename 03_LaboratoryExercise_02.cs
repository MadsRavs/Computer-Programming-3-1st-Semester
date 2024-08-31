using System.Diagnostics.Contracts;
using System.Reflection;
using System.Text.RegularExpressions;
    class ComputerAverageProgram{
        static void Main(string[]args){
            StartProgram();
        }
        //I made the whole program recursive so I can loop through the whole program and ask the user if he/she wants to restart
        static void StartProgram(){
            DisplayMessage("Welcome to STI-Dasmarinas online enrollment registration!");
            string name = GetStudentName();
            DisplayMessageNoLineBreak($"\nHi {name}, Do you want to enroll today?\nYes/No: ");
            bool Start1 = Decision();
            //Decision method determines the boolean value to start or not
            if (Start1==true){
            Console.WriteLine("---------------------------------------------------------------------------------------------");
                //Payment validation to check if the payment is enough
                bool nextStep = checkPayment();
                //nextStep boolean value determines the next step
                if(nextStep==true){
                    //declaration and initialization of files and file path
                    string directorPath = @"C:\Users\Prince Travis Amado\OneDrive - STI College Dasmarinas\Documents\Requirements";
                    string[] filesToCheck = {
                        "GoodMoral.pdf",
                        "form137.pdf",
                        "grades.xlsx"
                    };
                    //Displaying the names of the required files to the user and prompting the user to recheck the files
                    DisplayMessage("\nGreat! Here are the required files for you to submit in the \"Requirements\" folder: ");
                    foreach (string fileName in filesToCheck){
                        DisplayMessage($"{fileName}");
                    }
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    DisplayMessageNoLineBreak("Did you submit all the requirements?\nYes/No: ");
                    //boolean value Start2 determines the next step
                    bool Start2 = Decision();
                    if(Start2==true){
                        //File checking with the WaitAndCheckFiles method
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        WaitAndCheckFiles(directorPath,filesToCheck);   
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                    }
                    else{
                        DisplayMessage("Please submit the required files first");
                        DisplayMessage("Do you want to restart the program?");
                        RestartProgram();
                    }
                }
                else if(nextStep==false){
                    string output = "It seems that you have insufficient funds.\nTry again later... ";
                    Typings(output);
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    DisplayMessage("\nDo you want to restart the program?");
                    RestartProgram();  
                }  
            }
            else{
                DisplayMessage("Have a great day!");
            }
        }
         // student name method
        static string GetStudentName(){
            string studentName = null;
            bool validInput = false;
            //Exception Handling and validation of input
            while (!validInput){
                try{
                    DisplayMessageNoLineBreak("Enter your full name name[First Name, Middle Initial, Last Name]: ");
                    studentName = Console.ReadLine();
                    // Additional validation to ensure the name is not empty or whitespace
                    if (string.IsNullOrWhiteSpace(studentName)){
                        throw new ArgumentException("Student name cannot be empty or whitespace.");
                    }
                    // Regular expression to allow only alphabetic characters and spaces
                    if (!Regex.IsMatch(studentName, @"^[a-zA-Z\s.]+$")){
                        throw new ArgumentException("Student name can only contain letters and spaces.");
                    }
                    validInput = true; // If we reach this point, input is valid
                }
                catch (IOException ex){
                    Console.WriteLine("An input/output error occurred. Please try again.");
                    Console.WriteLine($"Error details: {ex.Message}");
                }
                catch (ArgumentException ex){
                    Console.WriteLine($"Invalid input: {ex.Message}");
                }
                catch (Exception ex){
                    Console.WriteLine("An unexpected error occurred. Please try again.");
                    Console.WriteLine($"Error details: {ex.Message}");
                }
            }
            return studentName;
        }
        //the decision method allows for cleaner and easier implementation of user decision input 
        static bool Decision(){
            string decision = Console.ReadLine();
            bool Start=false; 
            //using regex for input matching
            if(Regex.IsMatch(decision,@"^(?i)yes$")){
                Start = true;
            }
            else if(Regex.IsMatch(decision,@"^(?i)no$")){
                Start = false;
            }
            else{
                DisplayMessage("Invalid input");
                Decision();
            }
            return Start;
        }
        //Decision to restart the program
        static void RestartProgram(){
            bool startProgram = Decision();
            if(startProgram==true){
                StartProgram();
                Console.Clear();
            }
        }
        //the payment methods takes the input amount of money of the user and compares if it is enough to proceed with the next step by using bollean variables
        static bool checkPayment(){
            double tuitionFee = 32000.00;
            DisplayMessageNoLineBreak($"in order to proceed with the next step the minimum amount of tuitionfee is {tuitionFee},\nPlease enter the amount of money that you currently have: ");
            double Payment = Convert.ToDouble(Console.ReadLine());
            bool NextStep=false;
            if(Payment>=tuitionFee){
                NextStep = true;
            }
            else if (Payment<tuitionFee){
                NextStep=false;
            }
            else{
                Console.WriteLine("Invalid input");
                checkPayment();
            }
            return NextStep;
        }
        //File Checker
        static void WaitAndCheckFiles(string directoryPath, string[] filesToCheck){
            bool allFilesExist = true;
            for (int countdown = 3; countdown >= 0; countdown--){
                Console.WriteLine($"Please wait while we are checking your requirements... in {countdown}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            foreach (string fileName in filesToCheck){
                string filePath = Path.Combine(directoryPath, fileName);
                if (File.Exists(filePath)){
                    DisplayMessage($"File {fileName} exists");
                }
                else{
                    DisplayMessage($"File {fileName} does not exist");
                    allFilesExist = false;
                }
            }
            if (allFilesExist){
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                DisplayMessage("\nCongratulations, you are now enrolled at STI!\nWelcome to STI Dasmarinas!\n");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                DisplayMessage("\nDo you want to restart the program?");
                RestartProgram();
            }
            else{
                DisplayMessage("\nYou have not completed the requirements. Please upload the necessary files first.");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                DisplayMessage("\nDo you want to restart the program?");
                RestartProgram();
            }
        }
        //display message method
        static void DisplayMessage(string message){
            Typings($"{message}\n");
        }
        //display message na walang line break
         static void DisplayMessageNoLineBreak(string message){
            Typings($"{message}");
        }
         //Wala lang para cool typings
         static void Typings(string text){
            foreach (char c in text){
                Console.Write(c);
                Thread.Sleep(50); //delay
            }
        }
    }