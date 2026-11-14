using ProjectSchedule.Entities;

namespace ProjectSchedule.Repositories.Implementations;

internal class TeacherRepository : ITeacherRepository
{
    public void CreateTeacher(Teacher teacher) { }

    public void DeleteTeacher(int id) { }

    public Teacher ReadTeacherById(int id) =>
        Teacher.CreateEntity(0, string.Empty, string.Empty);

    public IEnumerable<Teacher> ReadTeachers() => [];

    public void UpdateTeacher(Teacher teacher) { }
}