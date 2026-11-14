using System.ComponentModel;

namespace ProjectSchedule.Entities;

public class Teacher
{
    [Browsable(false)]
    public int Id { get; private set; }

    [DisplayName("Имя")]
    public string FirstName { get; private set; } = string.Empty;

    [DisplayName("Фамилия")]
    public string LastName { get; private set; } = string.Empty;

    [Browsable(false)]
    public string FullName => $"{LastName} {FirstName}";

    public static Teacher CreateEntity(int id, string firstName, string lastName)
    {
        return new Teacher
        {
            Id = id,
            FirstName = firstName ?? string.Empty,
            LastName = lastName ?? string.Empty
        };
    }
}