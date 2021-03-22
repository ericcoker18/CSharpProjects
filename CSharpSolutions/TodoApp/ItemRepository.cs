using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoApp
{
    class ItemRepository
    {
        ItemContext context;

        public ItemRepository()
        {
            // This is creating a database for something that hasn't been made yet/ making sure it has been created.
            context = new ItemContext();
            context.Database.EnsureCreated();


        }
    
       

            public List<ToDoItem> GetAllItems()
            {
                IEnumerable<ToDoItem> list = context.toDoItems;
                return list.ToList();
            }

            public void AddItem(string description, string status)
            {
                ToDoItem item = new ToDoItem(description, status);
                context.toDoItems.Add(item);
                context.SaveChanges();
            }

            public void UpdateItem(int id, string newDescription, string newStatus)
            {
                ToDoItem findItem = context.toDoItems.Where(item => item.Id == id).FirstOrDefault();//method syntax
                                                                                                    //ToDoItem findItem2 = (from item in context.ToDoItems
                                                                                                    // where item.Id == id
                                                                                                    // select item).FirstOrDefault(); //query syntax
                findItem.Description = newDescription;
                findItem.Status = newStatus;

                //findItem.dueDate = newDueDate;
                context.Update(findItem);
                context.SaveChanges(); //have to update and 'push' changes to the Database
            }

            public void DeleteItem(int id)
            {
                ToDoItem findItem = context.toDoItems.Where(item => item.Id == id).FirstOrDefault();
                //context.ToDoItems.Remove(findItem); Does the same process of
                context.Remove(findItem);
                context.SaveChanges();
            }

            public List<ToDoItem> GetPendingItems()
            {
                IEnumerable<ToDoItem> list = context.toDoItems.Where(item => item.Status == "Pending");
                return list.ToList();
            }

            public List<ToDoItem> GetDoneItems()
            {
                IEnumerable<ToDoItem> list = context.toDoItems.Where(item => item.Status == "Done");
                return list.ToList();
            }
        }
    }







