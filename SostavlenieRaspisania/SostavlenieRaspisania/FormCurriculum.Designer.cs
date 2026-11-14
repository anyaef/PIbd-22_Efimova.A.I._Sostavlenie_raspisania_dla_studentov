namespace ProjectSchedule.Forms
{
    partial class FormCurriculum
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
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.comboBoxDiscipline = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelLectures = new System.Windows.Forms.Label();
            this.numericUpDownLectureCount = new System.Windows.Forms.NumericUpDown();
            this.labelLabs = new System.Windows.Forms.Label();
            this.numericUpDownLabCount = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLectureCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLabCount)).BeginInit();
            this.SuspendLayout();

            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Location = new System.Drawing.Point(20, 25);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(79, 15);
            this.labelDiscipline.TabIndex = 0;
            this.labelDiscipline.Text = "Дисциплина:";

            this.comboBoxDiscipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscipline.FormattingEnabled = true;
            this.comboBoxDiscipline.Location = new System.Drawing.Point(200, 22);
            this.comboBoxDiscipline.Name = "comboBoxDiscipline";
            this.comboBoxDiscipline.Size = new System.Drawing.Size(200, 23);
            this.comboBoxDiscipline.TabIndex = 1;

            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(20, 65);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(53, 15);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Группа:";

            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(200, 62);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(200, 23);
            this.comboBoxGroup.TabIndex = 3;

            this.labelLectures.AutoSize = true;
            this.labelLectures.Location = new System.Drawing.Point(20, 105);
            this.labelLectures.Name = "labelLectures";
            this.labelLectures.Size = new System.Drawing.Size(120, 15);
            this.labelLectures.TabIndex = 4;
            this.labelLectures.Text = "Количество лекций:";

            this.numericUpDownLectureCount.Location = new System.Drawing.Point(200, 102);
            this.numericUpDownLectureCount.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDownLectureCount.Name = "numericUpDownLectureCount";
            this.numericUpDownLectureCount.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownLectureCount.TabIndex = 5;

            this.labelLabs.AutoSize = true;
            this.labelLabs.Location = new System.Drawing.Point(20, 145);
            this.labelLabs.Name = "labelLabs";
            this.labelLabs.Size = new System.Drawing.Size(155, 15);
            this.labelLabs.TabIndex = 6;
            this.labelLabs.Text = "Количество лабораторных:";

            this.numericUpDownLabCount.Location = new System.Drawing.Point(200, 142);
            this.numericUpDownLabCount.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDownLabCount.Name = "numericUpDownLabCount";
            this.numericUpDownLabCount.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownLabCount.TabIndex = 7;

            this.buttonSave.Location = new System.Drawing.Point(80, 200);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);

            this.buttonCancel.Location = new System.Drawing.Point(240, 200);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 270);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownLabCount);
            this.Controls.Add(this.labelLabs);
            this.Controls.Add(this.numericUpDownLectureCount);
            this.Controls.Add(this.labelLectures);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxDiscipline);
            this.Controls.Add(this.labelDiscipline);
            this.Name = "FormCurriculum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Учебный план";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLectureCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLabCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.ComboBox comboBoxDiscipline;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelLectures;
        private System.Windows.Forms.NumericUpDown numericUpDownLectureCount;
        private System.Windows.Forms.Label labelLabs;
        private System.Windows.Forms.NumericUpDown numericUpDownLabCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}