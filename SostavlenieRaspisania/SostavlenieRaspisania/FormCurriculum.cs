using System;
using System.Linq;
using System.Windows.Forms;
using ProjectSchedule.Entities;
using ProjectSchedule.Repositories;

namespace ProjectSchedule.Forms;

public partial class FormCurriculum : Form
{
    // Объявляем поле на уровне класса (вот тут была ошибка, если скобка съехала)
    private readonly ICurriculumRepository _curriculumRepository;

    public FormCurriculum(ICurriculumRepository curriculumRepository,
        IDisciplineRepository disciplineRepository,
        IStudentGroupRepository studentGroupRepository)
    {
        // 1. Сначала инициализируем компоненты формы
        InitializeComponent();

        // 2. Сохраняем репозиторий (с защитой от null)
        _curriculumRepository = curriculumRepository
            ?? throw new ArgumentNullException(nameof(curriculumRepository));

        // 3. Безопасная привязка дисциплин
        var disciplines = disciplineRepository.ReadDisciplines() ?? [];
        if (disciplines.Any())
        {
            comboBoxDiscipline.DataSource = disciplines;
            comboBoxDiscipline.DisplayMember = "Name";
            comboBoxDiscipline.ValueMember = "Id";
        }

        // 4. Безопасная привязка групп
        var groups = studentGroupRepository.ReadStudentGroups() ?? [];
        if (groups.Any())
        {
            comboBoxGroup.DataSource = groups;
            comboBoxGroup.DisplayMember = "Name";
            comboBoxGroup.ValueMember = "Id";
        }

        StartPosition = FormStartPosition.CenterParent;
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxDiscipline.SelectedIndex < 0
                || comboBoxGroup.SelectedIndex < 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _curriculumRepository.CreateCurriculum(Curriculum.CreateOperation(
                0,
                (int)comboBoxDiscipline.SelectedValue!,
                (int)comboBoxGroup.SelectedValue!,
                Convert.ToInt32(numericUpDownLectureCount.Value),
                Convert.ToInt32(numericUpDownLabCount.Value)));

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}