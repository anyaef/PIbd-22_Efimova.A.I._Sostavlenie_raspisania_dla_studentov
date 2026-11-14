using ProjectSchedule.Entities;

namespace ProjectSchedule.Repositories.Implementations;

internal class ScheduleRepository : IScheduleRepository
{
    public void CreateSchedule(Schedule schedule) { }

    public IEnumerable<Schedule> ReadSchedules(DateTime? dateFrom = null,
        DateTime? dateTo = null, int? teacherId = null, int? auditoriumId = null) => [];
}