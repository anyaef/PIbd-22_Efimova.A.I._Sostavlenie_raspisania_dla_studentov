using ProjectSchedule.Entities;

namespace ProjectSchedule.Repositories.Implementations;

internal class StudentGroupRepository : IStudentGroupRepository
{
    public void CreateStudentGroup(StudentGroup group) { }

    public void DeleteStudentGroup(int id) { }

    public StudentGroup ReadStudentGroupById(int id) =>
        StudentGroup.CreateEntity(0, string.Empty, 0);

    public IEnumerable<StudentGroup> ReadStudentGroups() => [];

    public void UpdateStudentGroup(StudentGroup group) { }
}