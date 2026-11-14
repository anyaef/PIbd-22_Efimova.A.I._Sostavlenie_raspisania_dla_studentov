namespace ProjectSchedule.Forms
{
    partial class FormStudentGroup
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
            this.labelSize = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.SuspendLayout();

            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(112, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название группы:";

            this.textBoxName.Location = new System.Drawing.Point(180, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 23);
            this.textBoxName.TabIndex = 1;

            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(20, 65);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(139, 15);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Количество студентов:";

            this.numericUpDownSize.Location = new System.Drawing.Point(180, 62);
            this.numericUpDownSize.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDownSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownSize.TabIndex = 3;
            this.numericUpDownSize.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.buttonSave.Location = new System.Drawing.Point(80, 130);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);

            this.buttonCancel.Location = new System.Drawing.Point(220, 130);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormStudentGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Группа";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}