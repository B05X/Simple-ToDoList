namespace To_Do_List
{
    using System.Collections.Generic;
    using System;

    internal class Program
    {
        
        static List<string> todolist = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Simple To-Do List Tool"; 
            Login();

            while (true)
            {
                Menu();
            }
        }

        static void Login()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("   SIMPLE TO-DO LIST TOOL 2026   ");
            Console.WriteLine("=================================");
            Console.WriteLine("\nPress any key to start...");
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------- MAIN MENU -----------");
            Console.WriteLine("1. [Add]     New Task");
            Console.WriteLine("2. [View]    Current Tasks");
            Console.WriteLine("3. [Delete]  Delete Task");
            Console.WriteLine("4. [Exit]    Close Program");
            Console.WriteLine("---------------------------------");
            Console.Write("Your selection: ");

            if (int.TryParse(Console.ReadLine(), out int auswahl))
            {
                switch (auswahl)
                {
                    case 1:
                        NewTask();
                        break;
                    case 2:
                        ViewTask();
                        break;
                    case 3:
                        DeleteTask();
                        break;
                    case 4:
                        Console.WriteLine("\nGoodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nInvalid selection. Please choose 1, 2, or 3.");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }
        }

        static void NewTask()
        {
            Console.Clear();
            Console.WriteLine("----------- ADD TASK -----------");
            Console.WriteLine("What do you want to add?");
            Console.Write("> ");

            string task = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(task))
            {
                todolist.Add(task);
               
                Console.WriteLine($"\n[SUCCESS] Task #{todolist.Count} added: \"{task}\"");
            }
            else
            {
                Console.WriteLine("\n[ERROR] Task cannot be empty!");
            }

            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }

        static void ViewTask()
        {
            Console.Clear();
            Console.WriteLine("----------- YOUR TASKS -----------");

            if (todolist.Count == 0)
            {
                Console.WriteLine("Your list is currently empty.");
            }
            else
            {
               
                for (int i = 0; i < todolist.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todolist[i]}");
                }
            }

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
        static void DeleteTask()
        {
            Console.Clear();
            Console.WriteLine("----------- DELETE TASK -----------");

            if (todolist.Count == 0)
            {
                Console.WriteLine("Nothing to delete! The list is empty.");
            }
            else
            {
                
                for (int i = 0; i < todolist.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todolist[i]}");
                }

                Console.Write("\nEnter the number of the task to delete: ");

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    
                    int index = num - 1;

                    
                    if (index >= 0 && index < todolist.Count)
                    {
                        string removedTask = todolist[index];
                        todolist.RemoveAt(index);
                        Console.WriteLine($"\n[REMOVED] \"{removedTask}\" has been deleted.");
                    }
                    else
                    {
                        Console.WriteLine("\n[ERROR] This task number doesn't exist!");
                    }
                }
            }

            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }
    }
}