using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      // Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string description = Console.ReadLine();
      Item newItem = new Item(description);
      Console.WriteLine(newItem.Description);
    }
  }
}