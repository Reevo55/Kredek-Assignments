namespace RadoslawKarbowiakLabZadanie3
{
    partial class FormDiary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUsernameSign = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.labelAddTask = new System.Windows.Forms.Label();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.checkedListBoxImportance = new System.Windows.Forms.CheckedListBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.dailyTaskDiaryDataSet = new RadoslawKarbowiakLabZadanie3.DailyTaskDiaryDataSet();
            this.dailyTaskDiaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyTaskDiaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyTaskDiaryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsernameSign
            // 
            this.labelUsernameSign.AutoSize = true;
            this.labelUsernameSign.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernameSign.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsernameSign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsernameSign.Location = new System.Drawing.Point(26, 21);
            this.labelUsernameSign.Name = "labelUsernameSign";
            this.labelUsernameSign.Size = new System.Drawing.Size(160, 33);
            this.labelUsernameSign.TabIndex = 0;
            this.labelUsernameSign.Text = "Użytkownik:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserName.Location = new System.Drawing.Point(192, 21);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(98, 33);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Default";
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AllowUserToAddRows = false;
            this.dataGridViewTasks.AllowUserToResizeColumns = false;
            this.dataGridViewTasks.AllowUserToResizeRows = false;
            this.dataGridViewTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.dataGridViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.dataGridViewTasks.Location = new System.Drawing.Point(525, 131);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewTasks.Size = new System.Drawing.Size(325, 262);
            this.dataGridViewTasks.TabIndex = 2;
            // 
            // labelAddTask
            // 
            this.labelAddTask.AutoSize = true;
            this.labelAddTask.BackColor = System.Drawing.Color.Transparent;
            this.labelAddTask.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddTask.ForeColor = System.Drawing.Color.Black;
            this.labelAddTask.Location = new System.Drawing.Point(137, 108);
            this.labelAddTask.Name = "labelAddTask";
            this.labelAddTask.Size = new System.Drawing.Size(321, 30);
            this.labelAddTask.TabIndex = 3;
            this.labelAddTask.Text = "Dodaj zadanie do wykonania:";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTask.Location = new System.Drawing.Point(142, 141);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(300, 89);
            this.textBoxTask.TabIndex = 4;
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::RadoslawKarbowiakLabZadanie3.Properties.Resources.exitSmall;
            this.buttonExit.Location = new System.Drawing.Point(788, 11);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(62, 57);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddTask.FlatAppearance.BorderSize = 3;
            this.buttonAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.Location = new System.Drawing.Point(336, 262);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(106, 40);
            this.buttonAddTask.TabIndex = 6;
            this.buttonAddTask.Text = "Dodaj!";
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // checkedListBoxImportance
            // 
            this.checkedListBoxImportance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.checkedListBoxImportance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxImportance.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxImportance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkedListBoxImportance.FormattingEnabled = true;
            this.checkedListBoxImportance.Items.AddRange(new object[] {
            "Bardzo ważne ",
            "Ważne",
            "Średnio ważne",
            "Nie ważne"});
            this.checkedListBoxImportance.Location = new System.Drawing.Point(142, 236);
            this.checkedListBoxImportance.Name = "checkedListBoxImportance";
            this.checkedListBoxImportance.Size = new System.Drawing.Size(164, 88);
            this.checkedListBoxImportance.TabIndex = 7;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(616, 98);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(60, 30);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::RadoslawKarbowiakLabZadanie3.Properties.Resources.left;
            this.buttonLeft.Location = new System.Drawing.Point(563, 105);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(19, 18);
            this.buttonLeft.TabIndex = 9;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::RadoslawKarbowiakLabZadanie3.Properties.Resources.right;
            this.buttonRight.Location = new System.Drawing.Point(710, 105);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(21, 18);
            this.buttonRight.TabIndex = 10;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // dailyTaskDiaryDataSet
            // 
            this.dailyTaskDiaryDataSet.DataSetName = "DailyTaskDiaryDataSet";
            this.dailyTaskDiaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailyTaskDiaryDataSetBindingSource
            // 
            this.dailyTaskDiaryDataSetBindingSource.DataSource = this.dailyTaskDiaryDataSet;
            this.dailyTaskDiaryDataSetBindingSource.Position = 0;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 3;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(742, 409);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(79, 29);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Zapamiętaj";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDelete.FlatAppearance.BorderSize = 3;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(525, 409);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 29);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Usuń wybrane zadanie";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::RadoslawKarbowiakLabZadanie3.Properties.Resources.dairyNoteBackground;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.checkedListBoxImportance);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.labelAddTask);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelUsernameSign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Task Diary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyTaskDiaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyTaskDiaryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsernameSign;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Label labelAddTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.CheckedListBox checkedListBoxImportance;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.BindingSource dailyTaskDiaryDataSetBindingSource;
        private DailyTaskDiaryDataSet dailyTaskDiaryDataSet;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}