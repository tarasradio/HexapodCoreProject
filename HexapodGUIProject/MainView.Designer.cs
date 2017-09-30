namespace HexapodGUIProject
{
    partial class MainView
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.frundGeneratorView = new FrundGeneratorProject.Views.FrundGeneratorView();
            this.gateGeneratorView = new GateGeneratorProject.Views.GateGeneratorView();
            this.SuspendLayout();
            // 
            // frundGeneratorView
            // 
            this.frundGeneratorView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frundGeneratorView.Location = new System.Drawing.Point(163, 56);
            this.frundGeneratorView.Name = "frundGeneratorView";
            this.frundGeneratorView.Size = new System.Drawing.Size(150, 150);
            this.frundGeneratorView.TabIndex = 0;
            // 
            // gateGeneratorView
            // 
            this.gateGeneratorView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gateGeneratorView.Location = new System.Drawing.Point(420, 77);
            this.gateGeneratorView.Name = "gateGeneratorView";
            this.gateGeneratorView.Size = new System.Drawing.Size(150, 150);
            this.gateGeneratorView.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 455);
            this.Controls.Add(this.gateGeneratorView);
            this.Controls.Add(this.frundGeneratorView);
            this.Name = "MainView";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FrundGeneratorProject.Views.FrundGeneratorView frundGeneratorView;
        private GateGeneratorProject.Views.GateGeneratorView gateGeneratorView;
    }
}

