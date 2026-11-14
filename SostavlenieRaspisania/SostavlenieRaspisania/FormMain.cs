using Unity;

namespace ProjectSchedule.Forms;

public partial class FormMain : Form
{
    private readonly IUnityContainer _container;

    public FormMain(IUnityContainer container)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void AuditoriumsMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormAuditoriums>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void StudentGroupsMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormStudentGroups>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void TeachersMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormTeachers>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DisciplinesMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormDisciplines>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CurriculumsMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormCurriculums>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SchedulesMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormSchedules>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}