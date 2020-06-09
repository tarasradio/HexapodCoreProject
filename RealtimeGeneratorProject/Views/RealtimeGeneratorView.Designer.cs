namespace RealtimeGeneratorProject.Views
{
    partial class RealtimeGeneratorView
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
            this.runButton = new System.Windows.Forms.Button();
            this.portValueLabel = new System.Windows.Forms.Label();
            this.editPortNumber = new System.Windows.Forms.NumericUpDown();
            this.terminateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editPortNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.BackColor = System.Drawing.Color.GreenYellow;
            this.runButton.Location = new System.Drawing.Point(170, 3);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // portValueLabel
            // 
            this.portValueLabel.AutoSize = true;
            this.portValueLabel.Location = new System.Drawing.Point(3, 8);
            this.portValueLabel.Name = "portValueLabel";
            this.portValueLabel.Size = new System.Drawing.Size(29, 13);
            this.portValueLabel.TabIndex = 1;
            this.portValueLabel.Text = "Port:";
            // 
            // editPortNumber
            // 
            this.editPortNumber.Location = new System.Drawing.Point(38, 5);
            this.editPortNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.editPortNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.editPortNumber.Name = "editPortNumber";
            this.editPortNumber.Size = new System.Drawing.Size(120, 20);
            this.editPortNumber.TabIndex = 2;
            this.editPortNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editPortNumber.Value = new decimal(new int[] {
            55557,
            0,
            0,
            0});
            // 
            // terminateButton
            // 
            this.terminateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.terminateButton.BackColor = System.Drawing.Color.Yellow;
            this.terminateButton.Location = new System.Drawing.Point(251, 3);
            this.terminateButton.Name = "terminateButton";
            this.terminateButton.Size = new System.Drawing.Size(75, 23);
            this.terminateButton.TabIndex = 3;
            this.terminateButton.Text = "Terminate";
            this.terminateButton.UseVisualStyleBackColor = false;
            this.terminateButton.Click += new System.EventHandler(this.terminateButton_Click);
            // 
            // RealtimeGeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.terminateButton);
            this.Controls.Add(this.editPortNumber);
            this.Controls.Add(this.portValueLabel);
            this.Controls.Add(this.runButton);
            this.Name = "RealtimeGeneratorView";
            this.Size = new System.Drawing.Size(329, 37);
            ((System.ComponentModel.ISupportInitialize)(this.editPortNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label portValueLabel;
        private System.Windows.Forms.NumericUpDown editPortNumber;
        private System.Windows.Forms.Button terminateButton;
    }
}
