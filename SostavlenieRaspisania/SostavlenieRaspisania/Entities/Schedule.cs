using System.ComponentModel;
using ProjectSchedule.Entities.Enums;

namespace ProjectSchedule.Entities;

public class Schedule
{
    [Browsable(false)]
    public int Id { get; private set; }

    [Browsable(false)]
    public int CurriculumId { get; private set; }

    [Browsable(false)]
    public int TeacherId { get; private set; }

    [Browsable(false)]
    public int AuditoriumId { get; private set; }

    [DisplayName("Дисциплина / Группа")]
    public string CurriculumName { get; private set; } = string.Empty;

    [DisplayName("Преподаватель")]
    public string TeacherName { get; private set; } = string.Empty;

    [DisplayName("Аудитория")]
    public string AuditoriumName { get; private set; } = string.Empty;

    [DisplayName("Дата")]
    public DateTime Date { get; private set; }

    [DisplayName("Начало")]
    public TimeSpan StartTime { get; private set; }

    [DisplayName("Окончание")]
    public TimeSpan EndTime { get; private set; }

    [DisplayName("Тип занятия")]
    public LessonType Type { get; private set; }

    public static Schedule CreateOperation(int id, int curriculumId, int teacherId,
        int auditoriumId, DateTime date, TimeSpan startTime, TimeSpan endTime, LessonType type)
    {
        return new Schedule
        {
            Id = id,
            CurriculumId = curriculumId,
            TeacherId = teacherId,
            AuditoriumId = auditoriumId,
            Date = date,
            StartTime = startTime,
            EndTime = endTime,
            Type = type
        };
    }

    public static Schedule CreateOperation(int id, int curriculumId, int teacherId,
        int auditoriumId, DateTime date, TimeSpan startTime, TimeSpan endTime, LessonType type,
        string curriculumName, string teacherName, string auditoriumName)
    {
        return new Schedule
        {
            Id = id,
            CurriculumId = curriculumId,
            TeacherId = teacherId,
            AuditoriumId = auditoriumId,
            Date = date,
            StartTime = startTime,
            EndTime = endTime,
            Type = type,
            CurriculumName = curriculumName ?? string.Empty,
            TeacherName = teacherName ?? string.Empty,
            AuditoriumName = auditoriumName ?? string.Empty
        };
    }
}