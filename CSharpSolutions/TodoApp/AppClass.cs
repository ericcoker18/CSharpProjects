using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    class AppClass
    {

        ItemRepository Repo;

        public AppClass()
        {
            Repo = new ItemRepository();
        }
        private void DisplayAll()
        {
            List<ToDoItem> list = Repo.GetAllItems();
            ConsoleUtils.PrintAllItems(list);
        }

        public void ProcessInput()
        {
            DisplayAll();
            Console.WriteLine();
           string action = ConsoleUtils.DisplayMenu();
            while (action != "Exit")
            {
                switch (action)
                {
                    case "List":
                        DisplayAll();
                        break;
                    case "Add":
                        string[] newItem = ConsoleUtils.ItemUserInput();
                        Repo.AddItem(newItem[0], newItem[1]);
                        DisplayAll();
                        break;
                    case "Delete":
                        int GetItemId = ConsoleUtils.GetItemId();
                        Repo.DeleteItem(GetItemId);
                        DisplayAll();
                        break;
                    case "Update":
                        GetItemId = ConsoleUtils.GetItemId();
                        string[] UpdateItemInfo = ConsoleUtils.ItemUserInput();
                        Repo.UpdateItem(GetItemId, UpdateItemInfo[0], UpdateItemInfo[1]);
                        DisplayAll();
                        break;
                    case "Pending":
                        Repo.GetPendingItems();
                        Console.WriteLine();
                        DisplayAll();
                        break;
                    case "Done":
                        Repo.GetDoneItems();
                        Console.WriteLine();
                        DisplayAll();
                        break;
                    case "Exit":
                        ConsoleUtils.QuitProgram();
                        Console.WriteLine();
                        DisplayAll();
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid selection");
                        break;

                }
                action = ConsoleUtils.DisplayMenu();

            }

        }

    }
}
