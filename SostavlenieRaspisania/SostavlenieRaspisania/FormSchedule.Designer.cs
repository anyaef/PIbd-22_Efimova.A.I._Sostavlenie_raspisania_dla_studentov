namespace ProjectSchedule.Forms
{
    partial class FormSchedule
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
            this.labelCurriculum = new System.Windows.Forms.Label();
            this.comboBoxCurriculum = new System.Windows.Forms.ComboBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelAuditorium = new System.Windows.Forms.Label();
            this.comboBoxAuditorium = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelEnd = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelType = new System.Windows.Forms.Label();
            this.checkedListBoxType = new System.Windows.Forms.CheckedListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelCurriculum.AutoSize = true;
            this.labelCurriculum.Location = new System.Drawing.Point(20, 25);
            this.labelCurriculum.Name = "labelCurriculum";
            this.labelCurriculum.Size = new System.Drawing.Size(95, 15);
            this.labelCurriculum.TabIndex = 0;
            this.labelCurriculum.Text = "Учебный план:";

            this.comboBoxCurriculum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurriculum.FormattingEnabled = true;
            this.comboBoxCurriculum.Location = new System.Drawing.Point(200, 22);
            this.comboBoxCurriculum.Name = "comboBoxCurriculum";
            this.comboBoxCurriculum.Size = new System.Drawing.Size(250, 23);
            this.comboBoxCurriculum.TabIndex = 1;

            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(20, 65);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(89, 15);
            this.labelTeacher.TabIndex = 2;
            this.labelTeacher.Text = "Преподаватель:";

            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(200, 62);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(250, 23);
            this.comboBoxTeacher.TabIndex = 3;

            this.labelAuditorium.AutoSize = true;
            this.labelAuditorium.Location = new System.Drawing.Point(20, 105);
            this.labelAuditorium.Name = "labelAuditorium";
            this.labelAuditorium.Size = new System.Drawing.Size(72, 15);
            this.labelAuditorium.TabIndex = 4;
            this.labelAuditorium.Text = "Аудитория:";

            this.comboBoxAuditorium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuditorium.FormattingEnabled = true;
            this.comboBoxAuditorium.Location = new System.Drawing.Point(200, 102);
            this.comboBoxAuditorium.Name = "comboBoxAuditorium";
            this.comboBoxAuditorium.Size = new System.Drawing.Size(250, 23);
            this.comboBoxAuditorium.TabIndex = 5;

            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(20, 145);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 15);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Дата:";

            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(200, 142);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(150, 23);
            this.dateTimePickerDate.TabIndex = 7;

            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(20, 185);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(50, 15);
            this.labelStart.TabIndex = 8;
            this.labelStart.Text = "Начало:";

            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStart.Location = new System.Drawing.Point(200, 182);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowUpDown = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(100, 23);
            this.dateTimePickerStart.TabIndex = 9;

            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(20, 225);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(66, 15);
            this.labelEnd.TabIndex = 10;
            this.labelEnd.Text = "Окончание:";

            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(200, 222);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowUpDown = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(100, 23);
            this.dateTimePickerEnd.TabIndex = 11;

            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(20, 265);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(80, 15);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Тип занятия:";

            this.checkedListBoxType.FormattingEnabled = true;
            this.checkedListBoxType.Location = new System.Drawing.Point(200, 262);
            this.checkedListBoxType.Name = "checkedListBoxType";
            this.checkedListBoxType.Size = new System.Drawing.Size(250, 94);
            this.checkedListBoxType.TabIndex = 13;

            this.buttonSave.Location = new System.Drawing.Point(80, 380);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);

            this.buttonCancel.Location = new System.Drawing.Point(240, 380);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkedListBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxAuditorium);
            this.Controls.Add(this.labelAuditorium);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.comboBoxCurriculum);
            this.Controls.Add(this.labelCurriculum);
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Занятие";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelCurriculum;
        private System.Windows.Forms.ComboBox comboBoxCurriculum;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label labelAuditorium;
        private System.Windows.Forms.ComboBox comboBoxAuditorium;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.CheckedListBox checkedListBoxType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}