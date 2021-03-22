using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    public class ToDoItem
    {
       public int Id { get; private set; }
       public string Description { get; set; }
       public string Status { get; set; }

        public ToDoItem(string description, string status)
        {
            Description = description;
            Status = status;
            

        }

    }
}
