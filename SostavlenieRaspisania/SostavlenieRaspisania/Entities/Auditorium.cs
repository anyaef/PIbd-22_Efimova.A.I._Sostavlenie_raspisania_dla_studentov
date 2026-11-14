using System.ComponentModel;
using ProjectSchedule.Entities.Enums;

namespace ProjectSchedule.Entities;

public class Auditorium
{
    [Browsable(false)]
    public int Id { get; private set; }

    [DisplayName("Номер аудитории")]
    public string Number { get; private set; } = string.Empty;

    [DisplayName("Вместимость")]
    public int Capacity { get; private set; }

    [DisplayName("Тип")]
    public AuditoriumType Type { get; private set; }

    public static Auditorium CreateEntity(int id, string number, int capacity, AuditoriumType type)
    {
        return new Auditorium
        {
            Id = id,
            Number = number ?? string.Empty,
            Capacity = capacity,
            Type = type
        };
    }
}