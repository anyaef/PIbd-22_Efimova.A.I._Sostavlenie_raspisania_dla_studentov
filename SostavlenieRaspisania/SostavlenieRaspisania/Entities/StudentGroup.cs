using System.ComponentModel;

namespace ProjectSchedule.Entities;

public class StudentGroup
{
    [Browsable(false)]
    public int Id { get; private set; }

    [DisplayName("Название группы")]
    public string Name { get; private set; } = string.Empty;

    [DisplayName("Количество студентов")]
    public int Size { get; private set; }

    public static StudentGroup CreateEntity(int id, string name, int size)
    {
        return new StudentGroup
        {
            Id = id,
            Name = name ?? string.Empty,
            Size = size
        };
    }
}