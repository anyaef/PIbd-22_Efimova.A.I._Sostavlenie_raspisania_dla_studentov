using ProjectSchedule.Entities;
using ProjectSchedule.Entities.Enums;
using ProjectSchedule.Repositories;
using System.ComponentModel;

namespace ProjectSchedule.Forms;

public partial class FormDiscipline : Form
{
    private readonly IDisciplineRepository _disciplineRepository;
    private int? _disciplineId;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var discipline = _disciplineRepository.ReadDisciplineById(value);
                if (discipline == null) throw new InvalidDataException(nameof(discipline));

                textBoxName.Text = discipline.Name;
                numericUpDownCourse.Value = discipline.Course;
                _disciplineId = value;

                // Расставляем галочки для редактирования
                for (int i = 0; i < checkedListBoxType.Items.Count; i++)
                {
                    var item = (LessonType)checkedListBoxType.Items[i];
                    // Если такой тип есть в сохраненном LessonType, ставим галочку
                    if ((item & discipline.LessonType) != 0 && item != LessonType.None)
                    {
                        checkedListBoxType.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormDiscipline(IDisciplineRepository disciplineRepository)
    {
        InitializeComponent();
        _disciplineRepository = disciplineRepository
            ?? throw new ArgumentNullException(nameof(disciplineRepository));

        // Заполняем CheckedListBox значениями из Enum
        checkedListBoxType.Items.Clear();
        foreach (var type in Enum.GetValues(typeof(LessonType)))
        {
            if ((LessonType)type != LessonType.None) // None нам не нужен в списке
            {
                checkedListBoxType.Items.Add(type);
            }
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
                throw new Exception("Имеются незаполненные поля");

            if (_disciplineId.HasValue)
                _disciplineRepository.UpdateDiscipline(CreateDiscipline(_disciplineId.Value));
            else
                _disciplineRepository.CreateDiscipline(CreateDiscipline(0));

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Discipline CreateDiscipline(int id)
    {
        // Собираем выбранные галочки в одно значение
        LessonType selectedTypes = LessonType.None;
        foreach (var item in checkedListBoxType.CheckedItems)
        {
            selectedTypes |= (LessonType)item;
        }

        return Discipline.CreateEntity(
            id,
            textBoxName.Text,
            Convert.ToInt32(numericUpDownCourse.Value),
            selectedTypes);
    }
}