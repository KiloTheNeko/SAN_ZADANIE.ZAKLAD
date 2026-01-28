namespace Zad_Zaklad_V1;

public enum Position
{
    Director,
    Manager,
    Security,
    Janitor
}

public sealed class Worker(int id, string firstName, string lastName, int salary, Position position)
{
    public int Id { get; } = id;
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public int Salary { get; } = salary;
    public Position Position { get; } = position;
}

