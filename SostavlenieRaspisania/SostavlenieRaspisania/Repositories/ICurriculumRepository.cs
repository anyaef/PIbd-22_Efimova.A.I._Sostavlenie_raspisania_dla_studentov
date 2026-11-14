using ProjectSchedule.Entities;

namespace ProjectSchedule.Repositories;

public interface ICurriculumRepository
{
    IEnumerable<Curriculum> ReadCurriculums(DateTime? dateFrom = null,
        DateTime? dateTo = null, int? groupId = null, int? disciplineId = null);
    void CreateCurriculum(Curriculum curriculum);
}