using ProjectSchedule.Entities;
using ProjectSchedule.Repositories;
using Unity;

namespace ProjectSchedule.Forms;

public partial class FormAuditoriums : Form
{
    private readonly IUnityContainer _container;
    private readonly IAuditoriumRepository _auditoriumRepository;

    public FormAuditoriums(IUnityContainer container, IAuditoriumRepository auditoriumRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _auditoriumRepository = auditoriumRepository
            ?? throw new ArgumentNullException(nameof(auditoriumRepository));
        StartPosition = FormStartPosition.CenterParent;
    }

    private void FormAuditoriums_Load(object sender, EventArgs e)
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
            _container.Resolve<FormAuditorium>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonUpd_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }

        try
        {
            var form = _container.Resolve<FormAuditorium>();
            form.Id = findId;
            form.ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при изменении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonDel_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }

        if (MessageBox.Show("Удалить запись?", "Удаление",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
            return;
        }

        try
        {
            _auditoriumRepository.DeleteAuditorium(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList()
    {
        dataGridViewData.DataSource = _auditoriumRepository.ReadAuditoriums();
        if (dataGridViewData.Columns["Id"] != null)
        {
            dataGridViewData.Columns["Id"].Visible = false;
        }
    }

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewData.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
        return true;
    }
}