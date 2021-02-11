using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoMethod();

            
            


        }
        public static void ToDoMethod()
        {
            Console.WriteLine("Do you want to add an item, if not then enter done");
            string response = Console.ReadLine();

            List<ToDoItem> ToDoList = new List<ToDoItem>();

            while (response != "done")
            {
                Console.WriteLine("Enter a discription");
                string description = Console.ReadLine();
                Console.WriteLine("Enter a due date");
                string DueDate = Console.ReadLine();
                Console.WriteLine("Enter the priority as High, Medium, or Low");
                string priority = Console.ReadLine();
                ToDoList.Add(new ToDoItem(description, DueDate, priority));
                Console.WriteLine("Do you want to add an item, if not then enter done");
                response = Console.ReadLine();

            }
            foreach (ToDoItem thing in ToDoList) {
                Console.WriteLine(thing.description + " " + thing.DueDate+ " " + thing.priority);
            }
        }
    class ToDoItem
    {
        public string description { get; set; } 
        public string DueDate { get; set; }
        public string priority { get; set; }

        public ToDoItem(string Description, string dueDate, string Priority)
        {
            description = Description;
            DueDate = dueDate;
            priority = Priority;



        }

       
        }




    }
}