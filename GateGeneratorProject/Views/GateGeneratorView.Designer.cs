namespace GateGeneratorProject.Views
{
    partial class GateGeneratorView
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
            this.buttonRorward = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRorward
            // 
            this.buttonRorward.Location = new System.Drawing.Point(3, 3);
            this.buttonRorward.Name = "buttonRorward";
            this.buttonRorward.Size = new System.Drawing.Size(75, 23);
            this.buttonRorward.TabIndex = 0;
            this.buttonRorward.Text = "Вперед";
            this.buttonRorward.UseVisualStyleBackColor = true;
            this.buttonRorward.Click += new System.EventHandler(this.buttonRorward_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(3, 32);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // GateGeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRorward);
            this.Name = "GateGeneratorView";
            this.Size = new System.Drawing.Size(337, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRorward;
        private System.Windows.Forms.Button buttonStop;
    }
}
