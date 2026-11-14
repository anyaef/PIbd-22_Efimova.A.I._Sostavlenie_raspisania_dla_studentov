using ProjectSchedule.Entities;
using ProjectSchedule.Repositories;
using System.ComponentModel;

namespace ProjectSchedule.Forms;

public partial class FormTeacher : Form
{
    private readonly ITeacherRepository _teacherRepository;
    private int? _teacherId;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var teacher = _teacherRepository.ReadTeacherById(value);
                if (teacher == null)
                {
                    throw new InvalidDataException(nameof(teacher));
                }

                textBoxFirstName.Text = teacher.FirstName;
                textBoxLastName.Text = teacher.LastName;
                _teacherId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormTeacher(ITeacherRepository teacherRepository)
    {
        InitializeComponent();
        _teacherRepository = teacherRepository
            ?? throw new ArgumentNullException(nameof(teacherRepository));
        StartPosition = FormStartPosition.CenterParent;
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text)
                || string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_teacherId.HasValue)
            {
                _teacherRepository.UpdateTeacher(CreateTeacher(_teacherId.Value));
            }
            else
            {
                _teacherRepository.CreateTeacher(CreateTeacher(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Teacher CreateTeacher(int id) => Teacher.CreateEntity(
        id, textBoxFirstName.Text, textBoxLastName.Text);
}