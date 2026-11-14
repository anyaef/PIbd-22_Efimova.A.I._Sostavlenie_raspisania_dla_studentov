using ProjectSchedule.Entities;
using ProjectSchedule.Entities.Enums;

namespace ProjectSchedule.Repositories.Implementations;

internal class AuditoriumRepository : IAuditoriumRepository
{
    public void CreateAuditorium(Auditorium auditorium) { }

    public void DeleteAuditorium(int id) { }

    public Auditorium ReadAuditoriumById(int id) =>
        Auditorium.CreateEntity(0, string.Empty, 0, AuditoriumType.None);

    public IEnumerable<Auditorium> ReadAuditoriums() => [];

    public void UpdateAuditorium(Auditorium auditorium) { }
}