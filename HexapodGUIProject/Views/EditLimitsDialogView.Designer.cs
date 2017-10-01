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
            this.editRightValue = new System.Windows.Forms.NumericUpDown();
            this.editLeftValue = new System.Windows.Forms.NumericUpDown();
            this.rightLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.leftLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editRightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLeftValue)).BeginInit();
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
            this.editRightValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.editRightValue.Location = new System.Drawing.Point(182, 48);
            this.editRightValue.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.editRightValue.Name = "editRightValue";
            this.editRightValue.Size = new System.Drawing.Size(74, 20);
            this.editRightValue.TabIndex = 15;
            this.editRightValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editRightValue.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // editLeftValue
            // 
            this.editLeftValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.editLeftValue.Location = new System.Drawing.Point(182, 22);
            this.editLeftValue.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.editLeftValue.Name = "editLeftValue";
            this.editLeftValue.Size = new System.Drawing.Size(74, 20);
            this.editLeftValue.TabIndex = 14;
            this.editLeftValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editLeftValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // rightLimit
            // 
            this.rightLimit.Location = new System.Drawing.Point(102, 48);
            this.rightLimit.Name = "rightLimit";
            this.rightLimit.Size = new System.Drawing.Size(74, 20);
            this.rightLimit.TabIndex = 13;
            this.rightLimit.Text = "160";
            this.rightLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.leftLimit.Location = new System.Drawing.Point(102, 22);
            this.leftLimit.Name = "leftLimit";
            this.leftLimit.Size = new System.Drawing.Size(74, 20);
            this.leftLimit.TabIndex = 11;
            this.leftLimit.Text = "20";
            this.leftLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Controls.Add(this.editRightValue);
            this.Controls.Add(this.editLeftValue);
            this.Controls.Add(this.rightLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.leftLimit);
            this.Controls.Add(this.label1);
            this.Name = "EditLimitsDialogView";
            this.Text = "Изменение пределов";
            ((System.ComponentModel.ISupportInitialize)(this.editRightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLeftValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown editRightValue;
        private System.Windows.Forms.NumericUpDown editLeftValue;
        private System.Windows.Forms.TextBox rightLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox leftLimit;
        private System.Windows.Forms.Label label1;
    }
}