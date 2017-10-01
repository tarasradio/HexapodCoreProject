namespace HexapodGUIProject.Views
{
    partial class SelectedServoView
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
            this.checkBoxTrace = new System.Windows.Forms.CheckBox();
            this.checkBoxReverce = new System.Windows.Forms.CheckBox();
            this.checkBoxCalibration = new System.Windows.Forms.CheckBox();
            this.textServoNumber = new System.Windows.Forms.TextBox();
            this.textServoName = new System.Windows.Forms.TextBox();
            this.buttonEditLimits = new System.Windows.Forms.Button();
            this.buttonSetOffset = new System.Windows.Forms.Button();
            this.labelMinAngle = new System.Windows.Forms.TextBox();
            this.labelMaxAngle = new System.Windows.Forms.TextBox();
            this.labelCurrentAngle = new System.Windows.Forms.TextBox();
            this.trackAngle = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxTrace
            // 
            this.checkBoxTrace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxTrace.AutoSize = true;
            this.checkBoxTrace.Location = new System.Drawing.Point(5, 139);
            this.checkBoxTrace.Name = "checkBoxTrace";
            this.checkBoxTrace.Size = new System.Drawing.Size(164, 17);
            this.checkBoxTrace.TabIndex = 31;
            this.checkBoxTrace.Text = "Управление по положению";
            this.checkBoxTrace.UseVisualStyleBackColor = true;
            this.checkBoxTrace.CheckedChanged += new System.EventHandler(this.checkBoxTrace_CheckedChanged);
            // 
            // checkBoxReverce
            // 
            this.checkBoxReverce.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxReverce.AutoSize = true;
            this.checkBoxReverce.Location = new System.Drawing.Point(4, 213);
            this.checkBoxReverce.Name = "checkBoxReverce";
            this.checkBoxReverce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxReverce.Size = new System.Drawing.Size(89, 17);
            this.checkBoxReverce.TabIndex = 30;
            this.checkBoxReverce.Text = "Зеркальный";
            this.checkBoxReverce.UseVisualStyleBackColor = true;
            this.checkBoxReverce.CheckedChanged += new System.EventHandler(this.checkBoxReverce_CheckedChanged);
            // 
            // checkBoxCalibration
            // 
            this.checkBoxCalibration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxCalibration.AutoSize = true;
            this.checkBoxCalibration.Location = new System.Drawing.Point(5, 162);
            this.checkBoxCalibration.Name = "checkBoxCalibration";
            this.checkBoxCalibration.Size = new System.Drawing.Size(142, 17);
            this.checkBoxCalibration.TabIndex = 29;
            this.checkBoxCalibration.Text = "Калибровка двигателя";
            this.checkBoxCalibration.UseVisualStyleBackColor = true;
            this.checkBoxCalibration.CheckedChanged += new System.EventHandler(this.checkBoxCalibration_CheckedChanged);
            // 
            // textServoNumber
            // 
            this.textServoNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textServoNumber.Location = new System.Drawing.Point(4, 3);
            this.textServoNumber.Name = "textServoNumber";
            this.textServoNumber.Size = new System.Drawing.Size(186, 20);
            this.textServoNumber.TabIndex = 28;
            this.textServoNumber.Text = "Наименование";
            this.textServoNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textServoName
            // 
            this.textServoName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textServoName.Location = new System.Drawing.Point(4, 29);
            this.textServoName.Name = "textServoName";
            this.textServoName.Size = new System.Drawing.Size(186, 20);
            this.textServoName.TabIndex = 27;
            this.textServoName.Text = "Обозначение";
            this.textServoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonEditLimits
            // 
            this.buttonEditLimits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEditLimits.Location = new System.Drawing.Point(4, 55);
            this.buttonEditLimits.Name = "buttonEditLimits";
            this.buttonEditLimits.Size = new System.Drawing.Size(186, 22);
            this.buttonEditLimits.TabIndex = 26;
            this.buttonEditLimits.Text = "Изменение лимитов";
            this.buttonEditLimits.UseVisualStyleBackColor = true;
            this.buttonEditLimits.Click += new System.EventHandler(this.buttonEditLimits_Click);
            // 
            // buttonSetOffset
            // 
            this.buttonSetOffset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSetOffset.Location = new System.Drawing.Point(5, 185);
            this.buttonSetOffset.Name = "buttonSetOffset";
            this.buttonSetOffset.Size = new System.Drawing.Size(186, 22);
            this.buttonSetOffset.TabIndex = 25;
            this.buttonSetOffset.Text = "Записать смещение";
            this.buttonSetOffset.UseVisualStyleBackColor = true;
            this.buttonSetOffset.Click += new System.EventHandler(this.buttonSetOffset_Click);
            // 
            // labelMinAngle
            // 
            this.labelMinAngle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMinAngle.Location = new System.Drawing.Point(5, 83);
            this.labelMinAngle.Name = "labelMinAngle";
            this.labelMinAngle.Size = new System.Drawing.Size(58, 20);
            this.labelMinAngle.TabIndex = 24;
            this.labelMinAngle.Text = "90";
            this.labelMinAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMaxAngle
            // 
            this.labelMaxAngle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaxAngle.Location = new System.Drawing.Point(132, 83);
            this.labelMaxAngle.Name = "labelMaxAngle";
            this.labelMaxAngle.Size = new System.Drawing.Size(58, 20);
            this.labelMaxAngle.TabIndex = 23;
            this.labelMaxAngle.Text = "150";
            this.labelMaxAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCurrentAngle
            // 
            this.labelCurrentAngle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentAngle.Location = new System.Drawing.Point(68, 83);
            this.labelCurrentAngle.Name = "labelCurrentAngle";
            this.labelCurrentAngle.Size = new System.Drawing.Size(58, 20);
            this.labelCurrentAngle.TabIndex = 22;
            this.labelCurrentAngle.Text = "60";
            this.labelCurrentAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackAngle
            // 
            this.trackAngle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackAngle.AutoSize = false;
            this.trackAngle.LargeChange = 10;
            this.trackAngle.Location = new System.Drawing.Point(5, 109);
            this.trackAngle.Maximum = 150;
            this.trackAngle.Minimum = 60;
            this.trackAngle.Name = "trackAngle";
            this.trackAngle.Size = new System.Drawing.Size(186, 24);
            this.trackAngle.TabIndex = 21;
            this.trackAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackAngle.Value = 90;
            this.trackAngle.Scroll += new System.EventHandler(this.trackAngle_Scroll);
            // 
            // SelectedServoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxTrace);
            this.Controls.Add(this.checkBoxReverce);
            this.Controls.Add(this.checkBoxCalibration);
            this.Controls.Add(this.textServoNumber);
            this.Controls.Add(this.textServoName);
            this.Controls.Add(this.buttonEditLimits);
            this.Controls.Add(this.buttonSetOffset);
            this.Controls.Add(this.labelMinAngle);
            this.Controls.Add(this.labelMaxAngle);
            this.Controls.Add(this.labelCurrentAngle);
            this.Controls.Add(this.trackAngle);
            this.Name = "SelectedServoView";
            this.Size = new System.Drawing.Size(194, 261);
            ((System.ComponentModel.ISupportInitialize)(this.trackAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTrace;
        private System.Windows.Forms.CheckBox checkBoxReverce;
        private System.Windows.Forms.CheckBox checkBoxCalibration;
        private System.Windows.Forms.TextBox textServoNumber;
        private System.Windows.Forms.TextBox textServoName;
        private System.Windows.Forms.Button buttonEditLimits;
        private System.Windows.Forms.Button buttonSetOffset;
        private System.Windows.Forms.TextBox labelMinAngle;
        private System.Windows.Forms.TextBox labelMaxAngle;
        private System.Windows.Forms.TextBox labelCurrentAngle;
        private System.Windows.Forms.TrackBar trackAngle;
    }
}
