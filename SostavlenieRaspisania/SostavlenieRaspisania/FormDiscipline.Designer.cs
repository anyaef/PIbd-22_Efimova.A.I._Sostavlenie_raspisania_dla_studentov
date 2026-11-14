namespace ProjectSchedule.Forms
{
    partial class FormDiscipline
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.labelType = new System.Windows.Forms.Label();
            this.checkedListBoxType = new System.Windows.Forms.CheckedListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            this.SuspendLayout();

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(143, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название дисциплины:";

            // textBoxName
            this.textBoxName.Location = new System.Drawing.Point(180, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 23);
            this.textBoxName.TabIndex = 1;

            // labelCourse
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(20, 65);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(39, 15);
            this.labelCourse.TabIndex = 2;
            this.labelCourse.Text = "Курс:";

            // numericUpDownCourse
            this.numericUpDownCourse.Location = new System.Drawing.Point(180, 62);
            this.numericUpDownCourse.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            this.numericUpDownCourse.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownCourse.TabIndex = 3;
            this.numericUpDownCourse.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // labelType
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(20, 105);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(86, 15);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Типы занятий:";

            // checkedListBoxType
            this.checkedListBoxType.FormattingEnabled = true;
            this.checkedListBoxType.Location = new System.Drawing.Point(180, 102);
            this.checkedListBoxType.Name = "checkedListBoxType";
            this.checkedListBoxType.Size = new System.Drawing.Size(200, 94);
            this.checkedListBoxType.TabIndex = 5;

            // buttonSave
            this.buttonSave.Location = new System.Drawing.Point(80, 220);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);

            // buttonCancel
            this.buttonCancel.Location = new System.Drawing.Point(220, 220);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            // FormDiscipline
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkedListBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Дисциплина";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.CheckedListBox checkedListBoxType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}