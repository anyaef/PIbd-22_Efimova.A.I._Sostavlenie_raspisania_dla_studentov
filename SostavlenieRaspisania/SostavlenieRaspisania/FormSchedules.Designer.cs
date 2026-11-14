namespace ProjectSchedule.Forms
{
    partial class FormSchedules
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewData = new DataGridView();
            panelButtons = new Panel();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point(0, 0);
            dataGridViewData.Margin = new Padding(3, 4, 3, 4);
            dataGridViewData.MultiSelect = false;
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewData.Size = new Size(751, 385);
            dataGridViewData.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(634, 0);
            panelButtons.Margin = new Padding(3, 4, 3, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(117, 385);
            panelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = Properties.Resources.плюссамыйнорм;
            buttonAdd.Location = new Point(33, 169);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(57, 67);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // FormSchedules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 385);
            Controls.Add(panelButtons);
            Controls.Add(dataGridViewData);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSchedules";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Расписание";
            Load += FormSchedules_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdd;
    }
}