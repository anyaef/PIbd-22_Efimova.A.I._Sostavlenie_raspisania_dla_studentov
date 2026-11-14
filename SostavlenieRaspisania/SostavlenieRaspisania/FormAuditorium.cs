using ProjectSchedule.Entities;
using ProjectSchedule.Entities.Enums;
using ProjectSchedule.Repositories;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjectSchedule.Forms;

public partial class FormAuditorium : Form
{
    private readonly IAuditoriumRepository _auditoriumRepository;
    private int? _auditoriumId;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var auditorium = _auditoriumRepository.ReadAuditoriumById(value);
                if (auditorium == null)
                {
                    throw new InvalidDataException(nameof(auditorium));
                }

                textBoxNumber.Text = auditorium.Number;
                numericUpDownCapacity.Value = auditorium.Capacity;
                comboBoxType.SelectedItem = auditorium.Type;
                _auditoriumId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormAuditorium(IAuditoriumRepository auditoriumRepository)
    {
        InitializeComponent();
        _auditoriumRepository = auditoriumRepository
            ?? throw new ArgumentNullException(nameof(auditoriumRepository));
        comboBoxType.DataSource = Enum.GetValues(typeof(AuditoriumType));
        StartPosition = FormStartPosition.CenterParent;
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text)
                || comboBoxType.SelectedIndex < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_auditoriumId.HasValue)
            {
                _auditoriumRepository.UpdateAuditorium(CreateAuditorium(_auditoriumId.Value));
            }
            else
            {
                _auditoriumRepository.CreateAuditorium(CreateAuditorium(0));
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

    private Auditorium CreateAuditorium(int id) => Auditorium.CreateEntity(
        id,
        textBoxNumber.Text,
        Convert.ToInt32(numericUpDownCapacity.Value),
        (AuditoriumType)comboBoxType.SelectedItem);
}