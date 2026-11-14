using ProjectSchedule.Entities;

namespace ProjectSchedule.Repositories;

public interface IAuditoriumRepository
{
    IEnumerable<Auditorium> ReadAuditoriums();
    Auditorium ReadAuditoriumById(int id);
    void CreateAuditorium(Auditorium auditorium);
    void UpdateAuditorium(Auditorium auditorium);
    void DeleteAuditorium(int id);
}