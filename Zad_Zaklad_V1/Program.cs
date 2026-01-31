// See https://aka.ms/new-console-template for more information

using Zad_Zaklad_V1;

void WaitForKeyPress()
{
    while (true)
    {
        Console.WriteLine("Press Any To Continue.");
        Console.ReadKey(true);
        break;
    }
}

Console.WriteLine("Hello, user! please select a menu option");

var workers = new Worker[10];

workers[0] = new Worker(1, "Alice", "Kowalska", 15000m, Position.Director);
workers[1] = new Worker(2, "Robert", "Nowak", 14500m, Position.Director);
workers[2] = new Worker(3, "Marta", "Zielinska", 14800m, Position.Director);

workers[3] = new Worker(4, "Piotr", "Mazur", 9500m, Position.Manager);
workers[4] = new Worker(5, "Anna", "Lewandowska", 9200m, Position.Manager);
workers[5] = new Worker(6, "Tomasz", "Kaczmarek", 9800m, Position.Manager);

workers[6] = new Worker(7, "Jan", "Wojcik", 5200m, Position.Security);
workers[7] = new Worker(8, "Pawel", "Kaminski", 5400m, Position.Security);

workers[8] = new Worker(9, "Ewa", "Dabrowska", 4200m, Position.Janitor);
workers[9] = new Worker(10, "Karol", "Piotrowski", 4300m, Position.Janitor);


while (true)
{
    Console.Clear();
    Console.WriteLine("Menu options are:");
    Console.WriteLine("1) Salary By Position");
    Console.WriteLine("2) List Employees");
    Console.WriteLine("3) Exit");
    var option = Console.ReadLine()?.ToLower();
    if (option is "1" or "s" or "salary by position")
    {
        Console.Write("Enter Position: ");
        var input = Console.ReadLine();

        if (Enum.TryParse<Position>(input, true, out var position))
        {
            Console.Clear();
            var total = workers.SalaryByPosition(position);
            Console.WriteLine($"Total salary: {total}");
            WaitForKeyPress();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid position.");
            WaitForKeyPress();
        }
    }else if (option is "2" or "l" or "list employees")
    {
        Console.Clear();
        workers.Display();
        WaitForKeyPress();
    }else if (option is "3" or "exit" or "e")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid option.");
        WaitForKeyPress();
    }
}
