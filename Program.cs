

public static List<string> TaskList = new List<string>();



int menuSelected = 0;
        do
        {
            menuSelected = ShowMainMenu();
            if ((Menu) menuSelected == Menu.Add)
            {
                ShowMenuAdd();
            }
            else if ((Menu)menuSelected == Menu.Remove)
{
    ShowMenuRemove();
}
else if ((Menu)menuSelected == Menu.List)
{
    ShowMenuTaskList();
}
        } while ((Menu)menuSelected != Menu.Exit) ;

/// <summary>
/// Show the main menu 
/// </summary>
/// <returns>Returns option indicated by user</returns>
int ShowMainMenu()
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Ingrese la opción a realizar: ");
    Console.WriteLine("1. Nueva tarea");
    Console.WriteLine("2. Remover tarea");
    Console.WriteLine("3. Tareas pendientes");
    Console.WriteLine("4. Salir");

    // Read line
    string opcion = Console.ReadLine();
    return Convert.ToInt32(opcion);
}

void ShowMenuRemove()
{
    try
    {
        Console.WriteLine("Ingrese el número de la tarea a remover: ");
        // Show current taks
        ListTaks();

        string opcion = Console.ReadLine();
        // Remove one position
        int indexToRemove = Convert.ToInt32(opcion) - 1;
        if (indexToRemove > -1 && TaskList.Count > 0)
        {

            string taskDeleted = TaskList[indexToRemove];
            TaskList.RemoveAt(indexToRemove);
            Console.WriteLine("Tarea " + taskDeleted + " eliminada");

        }
    }
    catch (Exception)
    {
    }
}

void ShowMenuAdd()
{
    try
    {
        Console.WriteLine("Ingrese el nombre de la tarea: ");
        string taskAdded = Console.ReadLine();
        TaskList.Add(taskAdded);
        Console.WriteLine("Tarea registrada");
    }
    catch (Exception)
    {
    }
}

void ShowMenuTaskList()
{
    if (TaskList?.Count > 0)
    {
        ListTaks();

    }
    else
    {
        Console.WriteLine("No hay tareas por realizar");
    }

}

void ListTaks()
{

    Console.WriteLine("----------------------------------------");
    TaskList.ForEach(p => Console.WriteLine(TaskList.IndexOf(p) + 1 + "-" + p));

    Console.WriteLine("----------------------------------------");

}

public enum Menu
{
    Add = 1,
    Remove = 2,
    List = 3,
    Exit = 4
}



