namespace Zad_Zaklad_V1;

public static class WorkerMethods
{
    public static void Display(this IEnumerable<Worker> workers)
    {
        
    }
    
    public static decimal SalaryByPosition(this IEnumerable<Worker> workers, Position position)
    {
        decimal totalSalaryByPosition = 0.0m;
        foreach (var worker in workers)
        {
            if (worker.Position.Equals(position)) 
                totalSalaryByPosition += worker.Salary;
        }
        return totalSalaryByPosition;
    }
}