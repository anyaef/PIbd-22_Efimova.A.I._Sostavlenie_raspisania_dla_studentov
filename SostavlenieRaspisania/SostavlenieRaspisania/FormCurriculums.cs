using ProjectSchedule.Repositories;
using Unity;

namespace ProjectSchedule.Forms;

public partial class FormCurriculums : Form
{
    private readonly IUnityContainer _container;
    private readonly ICurriculumRepository _curriculumRepository;

    public FormCurriculums(IUnityContainer container, ICurriculumRepository curriculumRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _curriculumRepository = curriculumRepository
            ?? throw new ArgumentNullException(nameof(curriculumRepository));
        StartPosition = FormStartPosition.CenterParent;
    }

    private void FormCurriculums_Load(object sender, EventArgs e)
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
            _container.Resolve<FormCurriculum>().ShowDialog();
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
        dataGridViewData.DataSource = _curriculumRepository.ReadCurriculums();
        if (dataGridViewData.Columns["Id"] != null)
        {
            dataGridViewData.Columns["Id"].Visible = false;
        }
        if (dataGridViewData.Columns["DisciplineId"] != null)
        {
            dataGridViewData.Columns["DisciplineId"].Visible = false;
        }
        if (dataGridViewData.Columns["GroupId"] != null)
        {
            dataGridViewData.Columns["GroupId"].Visible = false;
        }
    }
}