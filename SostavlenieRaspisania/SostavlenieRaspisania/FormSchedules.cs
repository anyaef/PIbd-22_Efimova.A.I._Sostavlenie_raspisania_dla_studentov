using ProjectSchedule.Repositories;
using Unity;

namespace ProjectSchedule.Forms;

public partial class FormSchedules : Form
{
    private readonly IUnityContainer _container;
    private readonly IScheduleRepository _scheduleRepository;

    public FormSchedules(IUnityContainer container, IScheduleRepository scheduleRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _scheduleRepository = scheduleRepository
            ?? throw new ArgumentNullException(nameof(scheduleRepository));
        StartPosition = FormStartPosition.CenterParent;
    }

    private void FormSchedules_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormSchedule>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList()
    {
        dataGridViewData.DataSource = _scheduleRepository.ReadSchedules();
        if (dataGridViewData.Columns["Id"] != null)
        {
            dataGridViewData.Columns["Id"].Visible = false;
        }
        if (dataGridViewData.Columns["CurriculumId"] != null)
        {
            dataGridViewData.Columns["CurriculumId"].Visible = false;
        }
        if (dataGridViewData.Columns["TeacherId"] != null)
        {
            dataGridViewData.Columns["TeacherId"].Visible = false;
        }
        if (dataGridViewData.Columns["AuditoriumId"] != null)
        {
            dataGridViewData.Columns["AuditoriumId"].Visible = false;
        }
        if (dataGridViewData.Columns["Date"] != null)
        {
            dataGridViewData.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy";
        }
    }
}