using System;

namespace ST10085149_ICE_TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("Please type in the name of the first Item");
                    String itemName_A = Console.ReadLine();
                    Console.WriteLine("Please type in the price for the first Item");
                    double itemPrice_A = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Please type in the name of the second Item");
                    String itemName_B = Console.ReadLine();
                    Console.WriteLine("Please type in the price for the second Item");
                    double itemPrice_B = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Please type in the name of the third Item");
                    String itemName_C = Console.ReadLine();
                    Console.WriteLine("Please type in the price for the third Item");
                    double itemPrice_C = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Please type in the name of the forth Item");
                    String itemName_D = Console.ReadLine();
                    Console.WriteLine("Please type in the price for the forth Item");
                    double itemPrice_D = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Please type in the name of the firth Item");
                    String itemName_E = Console.ReadLine();
                    Console.WriteLine("Please type in the price for the firth Item");
                    double itemPrice_E = Double.Parse(Console.ReadLine());




                    Console.WriteLine("\n");

                    Cart c = new Cart(itemPrice_A, itemPrice_B, itemPrice_C, itemPrice_D, itemPrice_E);
                    Item i = new Item(itemName_A, itemName_B, itemName_C, itemName_D, itemName_E);


                    Console.WriteLine(i.ItemName_A + " " + "R" + c.ItemPrice_A + "\n"
                       + i.ItemName_B + " " + "R" + c.ItemPrice_B + "\n"
                       + i.ItemName_C + " " + "R" + c.ItemPrice_C + "\n"
                       + i.ItemName_D + " " + "R" + c.ItemPrice_D + "\n"
                       + i.ItemName_E + " " + "R" + c.ItemPrice_E + "\n"
                       + "************************************************\n"
                       + "Total" + " " + "R" + c.Total + "\n"
                       + "+ VAT" + " " + "R" + c.VAT + "\n"
                       + "************************************************\n"
                       + "Grand Total: R" + c.GrandTotal);

                    Console.WriteLine("\n");

                    Console.WriteLine("Do you want to stop the program from accepting the input, if you do type in {Exit}, if not then select any other key");
                    string exit = Console.ReadLine();
                    if (exit == "Exit")
                    {
                        System.Environment.Exit(0);
                    }

                    Console.WriteLine("\n");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    Console.WriteLine("\n");
                }

            }
        }
    }
}
