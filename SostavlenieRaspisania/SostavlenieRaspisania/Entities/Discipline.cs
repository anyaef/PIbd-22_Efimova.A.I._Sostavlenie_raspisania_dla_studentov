using System.ComponentModel;
using ProjectSchedule.Entities.Enums; // Не забудь про using для Enums!

namespace ProjectSchedule.Entities;

public class Discipline
{
    [Browsable(false)]
    public int Id { get; private set; }

    [DisplayName("Название дисциплины")]
    public string Name { get; private set; } = string.Empty;

    [DisplayName("Курс")]
    public int Course { get; private set; }

    [DisplayName("Типы занятий")]
    public LessonType LessonType { get; private set; } // <--- ДОБАВИЛИ ЭТО

    public static Discipline CreateEntity(int id, string name, int course, LessonType lessonType)
    {
        return new Discipline
        {
            Id = id,
            Name = name ?? string.Empty,
            Course = course,
            LessonType = lessonType // <--- И ЭТО
        };
    }
}