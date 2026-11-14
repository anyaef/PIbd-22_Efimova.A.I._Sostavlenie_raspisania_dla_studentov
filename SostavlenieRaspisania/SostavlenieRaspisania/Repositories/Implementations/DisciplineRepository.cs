using ProjectSchedule.Entities;

namespace ProjectSchedule.Repositories.Implementations;

internal class DisciplineRepository : IDisciplineRepository
{
    public void CreateDiscipline(Discipline discipline) { }

    public void DeleteDiscipline(int id) { }

    public Discipline ReadDisciplineById(int id) =>
        Discipline.CreateEntity(0, string.Empty, 0, ProjectSchedule.Entities.Enums.LessonType.None);

    public IEnumerable<Discipline> ReadDisciplines() => [];

    public void UpdateDiscipline(Discipline discipline) { }
}