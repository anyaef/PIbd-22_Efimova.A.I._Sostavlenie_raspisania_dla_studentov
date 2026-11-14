using ProjectSchedule.Entities;
using ProjectSchedule.Repositories;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjectSchedule.Forms;

public partial class FormStudentGroup : Form
{
    private readonly IStudentGroupRepository _studentGroupRepository;
    private int? _studentGroupId;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var group = _studentGroupRepository.ReadStudentGroupById(value);
                if (group == null)
                {
                    throw new InvalidDataException(nameof(group));
                }

                textBoxName.Text = group.Name;
                numericUpDownSize.Value = group.Size;
                _studentGroupId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormStudentGroup(IStudentGroupRepository studentGroupRepository)
    {
        InitializeComponent();
        _studentGroupRepository = studentGroupRepository
            ?? throw new ArgumentNullException(nameof(studentGroupRepository));
        StartPosition = FormStartPosition.CenterParent;
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_studentGroupId.HasValue)
            {
                _studentGroupRepository.UpdateStudentGroup(CreateGroup(_studentGroupId.Value));
            }
            else
            {
                _studentGroupRepository.CreateStudentGroup(CreateGroup(0));
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

    private StudentGroup CreateGroup(int id) => StudentGroup.CreateEntity(
        id,
        textBoxName.Text,
        Convert.ToInt32(numericUpDownSize.Value));
}