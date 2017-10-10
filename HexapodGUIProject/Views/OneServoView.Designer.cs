namespace HexapodGUIProject.Views
{
    partial class OneServoView
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
            this.maxAngleLabel = new System.Windows.Forms.Label();
            this.minAngleLabel = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxAngleLabel
            // 
            this.maxAngleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.maxAngleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxAngleLabel.Location = new System.Drawing.Point(36, 24);
            this.maxAngleLabel.Name = "maxAngleLabel";
            this.maxAngleLabel.Size = new System.Drawing.Size(30, 21);
            this.maxAngleLabel.TabIndex = 18;
            this.maxAngleLabel.Text = "140";
            this.maxAngleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minAngleLabel
            // 
            this.minAngleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.minAngleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minAngleLabel.Location = new System.Drawing.Point(0, 24);
            this.minAngleLabel.Name = "minAngleLabel";
            this.minAngleLabel.Size = new System.Drawing.Size(30, 21);
            this.minAngleLabel.TabIndex = 17;
            this.minAngleLabel.Text = "40";
            this.minAngleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSelect
            // 
            this.labelSelect.BackColor = System.Drawing.Color.White;
            this.labelSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelect.Location = new System.Drawing.Point(0, 0);
            this.labelSelect.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(66, 21);
            this.labelSelect.TabIndex = 16;
            this.labelSelect.Text = "4 (5)";
            this.labelSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSelect.Click += new System.EventHandler(this.labelSelect_Click);
            // 
            // OneServoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.maxAngleLabel);
            this.Controls.Add(this.minAngleLabel);
            this.Controls.Add(this.labelSelect);
            this.MaximumSize = new System.Drawing.Size(67, 47);
            this.Name = "OneServoView";
            this.Size = new System.Drawing.Size(67, 47);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label maxAngleLabel;
        private System.Windows.Forms.Label minAngleLabel;
        private System.Windows.Forms.Label labelSelect;
    }
}
