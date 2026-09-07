namespace Alma.Kernel.World.People;

public class PersonIdentity(string firstName, string lastName, int age)
{
    public string Name => $"{FirstName} {LastName}";
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public int Age { get; } = age;
}