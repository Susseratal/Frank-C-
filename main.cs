using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HelloWorld
{

  class Notebook //this is a class
  {
    private List<string> notes = new List<string>(); //<> = type of information in list e.g. <integer> or <string>
    public void addNote(string value)
    {
      notes.Add(value);
    }
    public ReadOnlyCollection<string> ReadOnly => notes.AsReadOnly();
  }
  class Program //this is also a class
  {

    static public void help() //this is like "def name():" in python. It has to be public so it can be accessed and it has to be static for some reason
    {
      Console.WriteLine ("To make simple calculations, type 'calculate'. ");
      Console.WriteLine (" ");
      Console.WriteLine ("To make a note, type 'make note'");
      Console.WriteLine (" ");
      Console.WriteLine ("To check your notes, type 'show notes'");
      Console.WriteLine (" ");
    }
    static void Main() //This is the start of the main program
    {
      Notebook notebook = new Notebook();

      while (true) //while loop
      {
        Console.WriteLine (" ");
        Console.WriteLine("What would you like to do? ");
        Console.WriteLine (" ");
        string command = Console.ReadLine();
        command = command.ToLower();
        switch (command) 
        {
          case "calculate":
            Console.WriteLine (" ");
            Console.WriteLine ("Please enter your first number as an integer: ");
            string num1str = Console.ReadLine();
            int num1 = Int32.Parse(num1str);
            Console.WriteLine (" ");
            Console.WriteLine ("Please enter your second number as an integer: ");
            string num2str = Console.ReadLine();
            int num2 = Int32.Parse(num2str);
            Console.WriteLine (" ");
            Console.WriteLine ("Please choose your operator of +, -, * or / ");
            string oper = Console.ReadLine();
            switch (oper)
            {
              case "+":
                Console.WriteLine (" ");
                Console.WriteLine($"{num1 + num2}");
                break;
              case "-":
                Console.WriteLine (" ");
                Console.WriteLine($"{num1 - num2}");
                break;
              case "*":
                Console.WriteLine (" ");
                Console.WriteLine($"{num1 * num2}");
                break;
              case "/":
                Console.WriteLine (" ");
                Console.WriteLine($"{num1 / num2}");
                break;
              default:
                Console.WriteLine (" ");
                Console.WriteLine("I am not programmed to respond in that area. ");
                break;
            }
            break;

          case "make note":
            Console.WriteLine (" ");
            Console.WriteLine ("What do you want me to remember?");
            Console.WriteLine (" ");
            string note = Console.ReadLine();
            notebook.addNote (note);
            break;
          
          case "show notes":
            Console.WriteLine (" ");
            Console.WriteLine ("Your notes are: ");
            Console.WriteLine (" ");
            foreach (string note1 in notebook.ReadOnly)
            {
              Console.WriteLine (note1);
            }
            break;

          case "show time":
            Console.WriteLine (" ");
            DateTime.Now.ToString("");
            Console.WriteLine(DateTime.Now);
            break;

          case "help":
            Console.WriteLine (" ");
            Program.help();
            break;

          case "quit":
            Console.WriteLine (" ");
            Console.WriteLine ("Goodbye. Thank you for using C# Frank for Desktop.");
            System.Threading.Thread.Sleep(500);
            Environment.Exit(0);
            break;

          default:
            Console.WriteLine (" ");
            Console.WriteLine ("What did you just say to me you cretin? You complete and utter buffoon");
            break;
        }
      }
    }
  }
}
