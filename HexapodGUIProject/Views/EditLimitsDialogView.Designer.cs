namespace HexapodGUIProject.Views
{
    partial class EditLimitsDialogView
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editUpperLimitValue = new System.Windows.Forms.NumericUpDown();
            this.editLowerLimitValue = new System.Windows.Forms.NumericUpDown();
            this.upperLimitValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lowerLimitValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editUpperLimitValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLowerLimitValue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(182, 74);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(101, 74);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Новое";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Старое";
            // 
            // editRightValue
            // 
            this.editUpperLimitValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.editUpperLimitValue.Location = new System.Drawing.Point(182, 48);
            this.editUpperLimitValue.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.editUpperLimitValue.Name = "editRightValue";
            this.editUpperLimitValue.Size = new System.Drawing.Size(74, 20);
            this.editUpperLimitValue.TabIndex = 15;
            this.editUpperLimitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editUpperLimitValue.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // editLeftValue
            // 
            this.editLowerLimitValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.editLowerLimitValue.Location = new System.Drawing.Point(182, 22);
            this.editLowerLimitValue.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.editLowerLimitValue.Name = "editLeftValue";
            this.editLowerLimitValue.Size = new System.Drawing.Size(74, 20);
            this.editLowerLimitValue.TabIndex = 14;
            this.editLowerLimitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editLowerLimitValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // rightLimit
            // 
            this.upperLimitValue.Location = new System.Drawing.Point(102, 48);
            this.upperLimitValue.Name = "rightLimit";
            this.upperLimitValue.Size = new System.Drawing.Size(74, 20);
            this.upperLimitValue.TabIndex = 13;
            this.upperLimitValue.Text = "160";
            this.upperLimitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Предел справа";
            // 
            // leftLimit
            // 
            this.lowerLimitValue.Location = new System.Drawing.Point(102, 22);
            this.lowerLimitValue.Name = "leftLimit";
            this.lowerLimitValue.Size = new System.Drawing.Size(74, 20);
            this.lowerLimitValue.TabIndex = 11;
            this.lowerLimitValue.Text = "20";
            this.lowerLimitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Предел слева";
            // 
            // EditLimitsDialogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 106);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editUpperLimitValue);
            this.Controls.Add(this.editLowerLimitValue);
            this.Controls.Add(this.upperLimitValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowerLimitValue);
            this.Controls.Add(this.label1);
            this.Name = "EditLimitsDialogView";
            this.Text = "Изменение пределов";
            ((System.ComponentModel.ISupportInitialize)(this.editUpperLimitValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLowerLimitValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown editUpperLimitValue;
        private System.Windows.Forms.NumericUpDown editLowerLimitValue;
        private System.Windows.Forms.TextBox upperLimitValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lowerLimitValue;
        private System.Windows.Forms.Label label1;
    }
}