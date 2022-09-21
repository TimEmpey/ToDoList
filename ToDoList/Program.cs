using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      bool userWantsToExit = false;

      while(!userWantsToExit)
      {
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("To Do List");
        Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View/Exit)");
        Console.WriteLine("-----------------------------------------------------------------------------");
        string choice = Console.ReadLine().ToLower();
        Console.WriteLine("-----------------------------------------------------------------------------");

        if (choice == "view") {
          // bool isEmpty = !Item.Any();
          if (Item.GetAll().Count == 0) {
            Console.WriteLine("Your list doesn't have any items yet!");
          } else {
            foreach (Item thisItem in Item.GetAll()) 
            {
              Console.WriteLine(thisItem.Description);
            }
          }
          
        } else if (choice == "add") {
          Console.WriteLine("Add something to your list:");
          string description = Console.ReadLine();
          Item newItem = new Item(description);
          foreach (Item thisItem in Item.GetAll()) 
          {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(thisItem.Description);
          }
        } else if (choice == "exit") {
          userWantsToExit = true;
        } else {
          Console.WriteLine("That is not an option");
        }
      }
    }
  }
}