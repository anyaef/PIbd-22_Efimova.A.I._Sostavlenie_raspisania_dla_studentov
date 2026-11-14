using System;
using System.Linq;
using System.Windows.Forms;
using ProjectSchedule.Entities;
using ProjectSchedule.Entities.Enums;
using ProjectSchedule.Repositories;

namespace ProjectSchedule.Forms;

public partial class FormSchedule : Form
{
    private readonly IScheduleRepository _scheduleRepository;

    public FormSchedule(IScheduleRepository scheduleRepository,
        ICurriculumRepository curriculumRepository,
        ITeacherRepository teacherRepository,
        IAuditoriumRepository auditoriumRepository)
    {
        InitializeComponent();

        _scheduleRepository = scheduleRepository
            ?? throw new ArgumentNullException(nameof(scheduleRepository));

        var curriculums = curriculumRepository.ReadCurriculums() ?? [];
        if (curriculums.Any())
        {
            comboBoxCurriculum.DataSource = curriculums;
            comboBoxCurriculum.DisplayMember = "DisciplineName";
            comboBoxCurriculum.ValueMember = "Id";
        }

        var teachers = teacherRepository.ReadTeachers() ?? [];
        if (teachers.Any())
        {
            comboBoxTeacher.DataSource = teachers;
            comboBoxTeacher.DisplayMember = "FullName";
            comboBoxTeacher.ValueMember = "Id";
        }

        var auditoriums = auditoriumRepository.ReadAuditoriums() ?? [];
        if (auditoriums.Any())
        {
            comboBoxAuditorium.DataSource = auditoriums;
            comboBoxAuditorium.DisplayMember = "Number";
            comboBoxAuditorium.ValueMember = "Id";
        }

        checkedListBoxType.Items.Clear();
        foreach (var type in Enum.GetValues(typeof(LessonType)))
        {
            if ((LessonType)type != LessonType.None)
            {
                checkedListBoxType.Items.Add(type);
            }
        }

        StartPosition = FormStartPosition.CenterParent;
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxCurriculum.SelectedIndex < 0
                || comboBoxTeacher.SelectedIndex < 0
                || comboBoxAuditorium.SelectedIndex < 0
                || checkedListBoxType.CheckedItems.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            LessonType selectedType = LessonType.None;
            foreach (var item in checkedListBoxType.CheckedItems)
            {
                selectedType |= (LessonType)item;
            }

            _scheduleRepository.CreateSchedule(Schedule.CreateOperation(
                0,
                (int)comboBoxCurriculum.SelectedValue!,
                (int)comboBoxTeacher.SelectedValue!,
                (int)comboBoxAuditorium.SelectedValue!,
                dateTimePickerDate.Value.Date,
                dateTimePickerStart.Value.TimeOfDay,
                dateTimePickerEnd.Value.TimeOfDay,
                selectedType));

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