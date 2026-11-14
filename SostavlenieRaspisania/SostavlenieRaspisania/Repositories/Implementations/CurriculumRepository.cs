using ProjectSchedule.Entities;

namespace ProjectSchedule.Repositories.Implementations;

internal class CurriculumRepository : ICurriculumRepository
{
    public void CreateCurriculum(Curriculum curriculum) { }

    public IEnumerable<Curriculum> ReadCurriculums(DateTime? dateFrom = null,
        DateTime? dateTo = null, int? groupId = null, int? disciplineId = null) => [];
}