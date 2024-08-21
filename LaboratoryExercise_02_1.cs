namespace DataTypesApp{
    class DataTypesProgram{
        static void Main(string[]args){
            //array declaration for fruit choices, para may pagpipilian 
            string[] fruit= {"Apple- enter 1","Banana- enter 2","Orange- enter 3","Solanum quitoense- enter 4"};
            //variable declaration
            int fruitQuantity;
            double fruitTotalPrice;
            double price;

            //for loop to print all values in the array and an input ng choice nila
            Console.WriteLine("Choose what fruit do you like?");
            foreach(string c in fruit ){
                string output1 = $"{c+"\n"}";
                Typings(output1);
            }
            string choice= Console.ReadLine();
            Console.Beep();
            //Quantity
            Console.WriteLine("\nEnter the number of pieces of fruits you like: ");
            fruitQuantity = int.Parse(Console.ReadLine());
             Console.Beep();
             Console.WriteLine();
            //Total price evaluation
            if (choice.ToLower()=="apple"|choice=="1"){
                price = 20.5;
                fruitTotalPrice = fruitQuantity*price;
                string output2 = $"You have chosen apple\nPrice is {price} pesos.\nYour total is {fruitTotalPrice} pesos";
                Typings(output2);
            }
            else if (choice.ToLower()=="banana"|choice=="2"){
                price = 36.5;
                fruitTotalPrice = fruitQuantity*price;
                string output2 = $"You have chosen banana\nPrice is {price} pesos.\nYour total is {fruitTotalPrice} pesos";
                Typings(output2);
            }
            else if (choice.ToLower()=="orange"|choice=="3"){
                price = 64.75;
                fruitTotalPrice = fruitQuantity*price;
                string output2 = $"You have chosen orange\nPrice is {price} pesos.\nYour total is {fruitTotalPrice} pesos";
                Typings(output2);
            }
            else if (choice.ToLower()=="solanum quitoense"|choice=="4"){
                price = 9999.99;
                fruitTotalPrice = fruitQuantity*price;
                string output2 = $"You have chosen solanum quitoense\nPrice is {price} pesos.\nYour total is {fruitTotalPrice} pesos";
                Typings(output2);
            }
            Console.WriteLine();
            Console.Beep();

            //Data type conversion for double to int
            Console.WriteLine("\nEnter the total price of "+fruitQuantity+" fruit(s) to convert to whole number: ");
            fruitTotalPrice = double.Parse(Console.ReadLine());
            int convertedfruitTotalPrice= (int)fruitTotalPrice;
            string output3 = $"The value of original price is {fruitTotalPrice} pesos. \nThe value converted total price is {convertedfruitTotalPrice} pesos.\nPress any key to exit...";
            Typings(output3);
            Console.ReadKey();
            Console.Beep();

        }
        //Wala lang para cool typings
         static void Typings(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(30); //delay
            }
        }
    }
}