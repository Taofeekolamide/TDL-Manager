using System;
using System.Collections.Generic;

class Program
{
    public static List<string> Tasks = new List<string>();
    public static bool ExitProgram = true;

    static void AddTask()
    {
        try
        {
            Console.Write("How many task do you want to add? : ");
            int NumberOfTask = int.Parse(Console.ReadLine());
            if (NumberOfTask > 0)
            {
                for (int i = 0; i < NumberOfTask; i++)
                {
                    Console.Write("\nEnter a new Task : ");
                    string NewTask = Console.ReadLine();
                    if (!Tasks.Contains(NewTask))
                    {
                        Tasks.Add(NewTask);
                        Console.WriteLine("Task added successfully \n");
                    }
                    else
                    {
                        Console.WriteLine("Task already exist");
                    }
                }
            }
            else
            {
                Console.WriteLine("Task connot be less than 1\n");
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("The input should be a number");
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void ViewTask()
    {
        Console.WriteLine($"You have {Tasks.Count} task(s) left");
        for (int i = 0; i < Tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Tasks[i]}");
        }
    }

    public static void MarkTask()
    {
        if (Tasks.Count > 0)
        {
            Console.WriteLine($"You have {Tasks.Count} task(s) left");
            for (int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Tasks[i]}");
            }
            try
            {
                Console.Write($"\nEnter the task you want to mark done : ");
                int Mark = Convert.ToInt32(Console.ReadLine());
                if (Tasks.Contains(Tasks[Mark - 1]))
                {
                    Tasks.Remove(Tasks[Mark - 1]);
                    Console.WriteLine("Task has been successfully marked");
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("The task does not exist");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("The input should be a number");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        else
        {
            Console.WriteLine("You have no task yet");
        }
    }

    public static void DeleteTask()
    {
        if (Tasks.Count > 0)
        {
            Console.WriteLine($"You have {Tasks.Count} task(s) left");
            for (int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Tasks[i]}");
            }
            Console.Write($"\nDo you want to delete a task or all task, \"a task\" for one task, \"all\" for all task : ");
            string Delete = Console.ReadLine().ToLower();
            if (Delete == "a task")
            {
                try
                {
                    Console.Write($"what task number do want to delete ? ");
                    int TaskToDelete = Convert.ToInt32(Console.ReadLine());
                    if (Tasks.Contains(Tasks[TaskToDelete - 1]))
                    {
                        Tasks.Remove(Tasks[TaskToDelete - 1]);
                        Console.WriteLine("Task deleted successfully");
                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Task does not exist");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("The input should be a number");
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            if (Delete == "delete all" || Delete == "all")
            {
                Tasks.Clear();
                Console.WriteLine("All Task deleted successfully");
            }
        }
        else
        {
            Console.WriteLine("You have no task left");
        }
    }

    static void Main()
    {
        while (ExitProgram)
        {
            Console.WriteLine($"\nDo you want to \n1. Add Task \n2. View Task \n3. Mark Task \n4. Delete task \n5. Exit \n");
            string action = Console.ReadLine().ToLower();

            //exit program
            if (action == "exit" || action == "5")
            {
                ExitProgram = false;
            }

            //Task add
            if (action == "add" || action == "add task" || action == "1")
            {
                AddTask();
            }

            //view tasks
            if (action == "view" || action == "view tasks" || action == "view task" || action == "2")
            {
                ViewTask();
            }

            //Mark task
            if (action == "mark" || action == "mark tasks" || action == "mark task" || action == "3")
            {
                MarkTask();
            }

            //Delete task
            if (action == "delete" || action == "delete tasks" || action == "delete task" || action == "4")
            {
                DeleteTask();
            }
        }
    }
}



