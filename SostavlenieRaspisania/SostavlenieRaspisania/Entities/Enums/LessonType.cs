namespace ProjectSchedule.Entities.Enums;

[Flags]
public enum LessonType
{
    None = 0,
    Lecture = 1,
    Laboratory = 2,
    Practice = 4
}