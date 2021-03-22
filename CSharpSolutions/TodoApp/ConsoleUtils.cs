using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TodoApp
{
    class ConsoleUtils
    {
        public static string DisplayMenu()
        {
            string menu = "Choose one of the following actions. " +
                "\n 'List' List All Items " +
                "\n 'Add' Add A New Item  " +
                "\n 'Delete' Delete An Item " +
                "\n 'Update' Update An Item " +
                "\n 'Pending' List All Of The Pending Items " +
                "\n 'Done' List All Of The Done Items " +
                "\n 'Exit' Exits your program ";
            Console.WriteLine(menu);
            string action = Console.ReadLine();
            action = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(action);
            return action; 


        }

        public static int GetItemId() {
            Console.WriteLine("Which Item Would You Like To Update/Delete?");
            String UpdateDeleteInput = Console.ReadLine();
            int UpdateDeleteInput1 = int.Parse(UpdateDeleteInput);
            return UpdateDeleteInput1;
            // This method is asking a user for an string that would represent the item ID to Update or delete an item, which then needs to be Parsed to an Int because the item id is an Int, and then Returns Converted String to Int (This method is finding the item to Update or Delete)



}
        public static void PrintAllItems(List<ToDoItem> List)
        {
            Console.Clear();
            foreach(ToDoItem item in List)
            {
                Console.WriteLine($"{item.Id} | {item.Description} | {item.Status}");
            } // This method clears the console of previous things, and then uses a foreach loop, which instantiates and Item for our ToDoItem Class and then we use string interpolation to write back onto our console the neccesary pramaters in our ToDoItem Class. (Each item consist of an Id, Descript, and a Status.


        }
        public static string[] ItemUserInput()
        {
            string[] UserInput = new string[2];
            Console.WriteLine("Whats the description of the item?");
            UserInput[0] = Console.ReadLine();
            Console.WriteLine("Whats the status of the item?");
            UserInput[1] = Console.ReadLine();
            return UserInput; // This is using a string array to take in the descript, and status of an item. THIS HAS A VARIABLE SO IT HAS TO RETURN A VALUE (RETURN = A STRING ARRAY)
        }
        public static void QuitProgram()
        {
            Console.WriteLine("Program will now Exit");
        } // THIS DOESNT HAVE A VARIABLE TO RETURN (VOID) THEREFORE WE DO NOT NEED A RETURN VALUE BECAUSE IT IS SIMPLY STATING SOMETHING
    }

}


