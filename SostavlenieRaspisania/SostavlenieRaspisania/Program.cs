using ProjectSchedule.Forms;
using ProjectSchedule.Repositories;
using ProjectSchedule.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace ProjectSchedule;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(CreateContainer().Resolve<FormMain>());
    }

    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();

        container.RegisterType<IAuditoriumRepository, AuditoriumRepository>(new TransientLifetimeManager());
        container.RegisterType<IStudentGroupRepository, StudentGroupRepository>(new TransientLifetimeManager());
        container.RegisterType<ITeacherRepository, TeacherRepository>(new TransientLifetimeManager());
        container.RegisterType<IDisciplineRepository, DisciplineRepository>(new TransientLifetimeManager());
        container.RegisterType<ICurriculumRepository, CurriculumRepository>(new TransientLifetimeManager());
        container.RegisterType<IScheduleRepository, ScheduleRepository>(new TransientLifetimeManager());

        return container;
    }
}