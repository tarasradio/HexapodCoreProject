namespace HexapodGUIProject.Views
{
    partial class ServousListView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.servousList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.servousList)).BeginInit();
            this.SuspendLayout();
            // 
            // servousList
            // 
            this.servousList.AllowUserToAddRows = false;
            this.servousList.AllowUserToDeleteRows = false;
            this.servousList.AllowUserToResizeRows = false;
            this.servousList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servousList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.servousList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.servousList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.servousList.DefaultCellStyle = dataGridViewCellStyle1;
            this.servousList.Location = new System.Drawing.Point(3, 3);
            this.servousList.MultiSelect = false;
            this.servousList.Name = "servousList";
            this.servousList.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.servousList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.servousList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servousList.Size = new System.Drawing.Size(662, 371);
            this.servousList.TabIndex = 2;
            this.servousList.SelectionChanged += new System.EventHandler(this.servousList_SelectionChanged);
            // 
            // ServousListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.servousList);
            this.Name = "ServousListView";
            this.Size = new System.Drawing.Size(668, 377);
            ((System.ComponentModel.ISupportInitialize)(this.servousList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView servousList;
    }
}
