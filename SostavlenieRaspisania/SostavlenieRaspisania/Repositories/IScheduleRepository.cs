using ProjectSchedule.Entities;

namespace ProjectSchedule.Repositories;

public interface IScheduleRepository
{
    IEnumerable<Schedule> ReadSchedules(DateTime? dateFrom = null,
        DateTime? dateTo = null, int? teacherId = null, int? auditoriumId = null);
    void CreateSchedule(Schedule schedule);
}