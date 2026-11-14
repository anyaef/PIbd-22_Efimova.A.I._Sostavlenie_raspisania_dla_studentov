using System.ComponentModel;

namespace ProjectSchedule.Entities;

public class Curriculum
{
    [Browsable(false)]
    public int Id { get; private set; }

    [Browsable(false)]
    public int DisciplineId { get; private set; }

    [Browsable(false)]
    public int GroupId { get; private set; }

    [DisplayName("Дисциплина")]
    public string DisciplineName { get; private set; } = string.Empty;

    [DisplayName("Группа")]
    public string GroupName { get; private set; } = string.Empty;

    [DisplayName("Лекции")]
    public int LectureCount { get; private set; }

    [DisplayName("Лабораторные")]
    public int LabCount { get; private set; }

    public static Curriculum CreateOperation(int id, int disciplineId, int groupId,
        int lectureCount, int labCount)
    {
        return new Curriculum
        {
            Id = id,
            DisciplineId = disciplineId,
            GroupId = groupId,
            LectureCount = lectureCount,
            LabCount = labCount
        };
    }

    public static Curriculum CreateOperation(int id, int disciplineId, int groupId,
        int lectureCount, int labCount, string disciplineName, string groupName)
    {
        return new Curriculum
        {
            Id = id,
            DisciplineId = disciplineId,
            GroupId = groupId,
            LectureCount = lectureCount,
            LabCount = labCount,
            DisciplineName = disciplineName ?? string.Empty,
            GroupName = groupName ?? string.Empty
        };
    }
}