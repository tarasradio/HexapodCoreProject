namespace FrundGeneratorProject.Views
{
    partial class FrundGeneratorView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editFileName = new System.Windows.Forms.TextBox();
            this.stopMoveButton = new System.Windows.Forms.Button();
            this.addFileButton = new System.Windows.Forms.Button();
            this.startMoveButton = new System.Windows.Forms.Button();
            this.buttonFilePosition = new System.Windows.Forms.Button();
            this.buttonStartPosition = new System.Windows.Forms.Button();
            this.filesListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.filesListView)).BeginInit();
            this.SuspendLayout();
            // 
            // editFileName
            // 
            this.editFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editFileName.Location = new System.Drawing.Point(3, 5);
            this.editFileName.Name = "editFileName";
            this.editFileName.Size = new System.Drawing.Size(316, 20);
            this.editFileName.TabIndex = 27;
            // 
            // stopMoveButton
            // 
            this.stopMoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopMoveButton.Location = new System.Drawing.Point(331, 243);
            this.stopMoveButton.Name = "stopMoveButton";
            this.stopMoveButton.Size = new System.Drawing.Size(96, 23);
            this.stopMoveButton.TabIndex = 25;
            this.stopMoveButton.Text = "Остановка";
            this.stopMoveButton.UseVisualStyleBackColor = true;
            this.stopMoveButton.Click += new System.EventHandler(this.stopMoveButton_Click);
            // 
            // addFileButton
            // 
            this.addFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFileButton.Location = new System.Drawing.Point(325, 3);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(102, 23);
            this.addFileButton.TabIndex = 24;
            this.addFileButton.Text = "Загрузить файл";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // startMoveButton
            // 
            this.startMoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startMoveButton.Location = new System.Drawing.Point(229, 243);
            this.startMoveButton.Name = "startMoveButton";
            this.startMoveButton.Size = new System.Drawing.Size(96, 23);
            this.startMoveButton.TabIndex = 23;
            this.startMoveButton.Text = "Запуск";
            this.startMoveButton.UseVisualStyleBackColor = true;
            this.startMoveButton.Click += new System.EventHandler(this.startMoveButton_Click);
            // 
            // buttonFilePosition
            // 
            this.buttonFilePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFilePosition.Location = new System.Drawing.Point(105, 243);
            this.buttonFilePosition.Name = "buttonFilePosition";
            this.buttonFilePosition.Size = new System.Drawing.Size(96, 23);
            this.buttonFilePosition.TabIndex = 22;
            this.buttonFilePosition.Text = "Из файла";
            this.buttonFilePosition.UseVisualStyleBackColor = true;
            // 
            // buttonStartPosition
            // 
            this.buttonStartPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStartPosition.Location = new System.Drawing.Point(3, 243);
            this.buttonStartPosition.Name = "buttonStartPosition";
            this.buttonStartPosition.Size = new System.Drawing.Size(96, 23);
            this.buttonStartPosition.TabIndex = 21;
            this.buttonStartPosition.Text = "Начальное";
            this.buttonStartPosition.UseVisualStyleBackColor = true;
            // 
            // filesListView
            // 
            this.filesListView.AllowUserToAddRows = false;
            this.filesListView.AllowUserToDeleteRows = false;
            this.filesListView.AllowUserToResizeRows = false;
            this.filesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.filesListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filesListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.filesListView.DefaultCellStyle = dataGridViewCellStyle5;
            this.filesListView.Location = new System.Drawing.Point(3, 31);
            this.filesListView.MultiSelect = false;
            this.filesListView.Name = "filesListView";
            this.filesListView.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.filesListView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.filesListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filesListView.Size = new System.Drawing.Size(424, 206);
            this.filesListView.TabIndex = 28;
            // 
            // FrundGeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.editFileName);
            this.Controls.Add(this.stopMoveButton);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.startMoveButton);
            this.Controls.Add(this.buttonFilePosition);
            this.Controls.Add(this.buttonStartPosition);
            this.Name = "FrundGeneratorView";
            this.Size = new System.Drawing.Size(430, 269);
            ((System.ComponentModel.ISupportInitialize)(this.filesListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editFileName;
        private System.Windows.Forms.Button stopMoveButton;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Button startMoveButton;
        private System.Windows.Forms.Button buttonFilePosition;
        private System.Windows.Forms.Button buttonStartPosition;
        private System.Windows.Forms.DataGridView filesListView;
    }
}
