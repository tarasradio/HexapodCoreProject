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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.updateListPortsButton = new System.Windows.Forms.ToolStripButton();
            this.listPortsBox = new System.Windows.Forms.ToolStripComboBox();
            this.connectButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.selectedServoView = new HexapodGUIProject.Views.SelectedServoView();
            this.servousListView = new HexapodGUIProject.Views.ServousListView();
            this.gateGeneratorView = new GateGeneratorProject.Views.GateGeneratorView();
            this.frundGeneratorView = new FrundGeneratorProject.Views.FrundGeneratorView();
            this.logView = new HexapodGUIProject.Views.LogView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateListPortsButton,
            this.listPortsBox,
            this.connectButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(794, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // updateListPortsButton
            // 
            this.updateListPortsButton.AutoSize = false;
            this.updateListPortsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.updateListPortsButton.Image = ((System.Drawing.Image)(resources.GetObject("updateListPortsButton.Image")));
            this.updateListPortsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateListPortsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateListPortsButton.Name = "updateListPortsButton";
            this.updateListPortsButton.Size = new System.Drawing.Size(36, 36);
            this.updateListPortsButton.Text = "toolStripButton1";
            this.updateListPortsButton.Click += new System.EventHandler(this.updateListPortsButton_Click);
            // 
            // listPortsBox
            // 
            this.listPortsBox.Name = "listPortsBox";
            this.listPortsBox.Size = new System.Drawing.Size(121, 39);
            // 
            // connectButton
            // 
            this.connectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectButton.Image = ((System.Drawing.Image)(resources.GetObject("connectButton.Image")));
            this.connectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(93, 36);
            this.connectButton.Text = "Подключиться";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionState
            // 
            this.connectionState.Name = "connectionState";
            this.connectionState.Size = new System.Drawing.Size(95, 17);
            this.connectionState.Text = "ConnectionState";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 251);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.servousListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица приводов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Управление структурой";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gateGeneratorView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(572, 225);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Управление походкой";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.frundGeneratorView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(572, 225);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Управление из ФРУНД";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // selectedServoView
            // 
            this.selectedServoView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedServoView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedServoView.Location = new System.Drawing.Point(572, 42);
            this.selectedServoView.Name = "selectedServoView";
            this.selectedServoView.Size = new System.Drawing.Size(210, 388);
            this.selectedServoView.TabIndex = 8;
            // 
            // servousListView
            // 
            this.servousListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servousListView.Location = new System.Drawing.Point(6, 6);
            this.servousListView.Name = "servousListView";
            this.servousListView.Size = new System.Drawing.Size(534, 213);
            this.servousListView.TabIndex = 6;
            // 
            // gateGeneratorView
            // 
            this.gateGeneratorView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gateGeneratorView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gateGeneratorView.Location = new System.Drawing.Point(6, 6);
            this.gateGeneratorView.Name = "gateGeneratorView";
            this.gateGeneratorView.Size = new System.Drawing.Size(560, 213);
            this.gateGeneratorView.TabIndex = 1;
            // 
            // frundGeneratorView
            // 
            this.frundGeneratorView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frundGeneratorView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frundGeneratorView.Location = new System.Drawing.Point(6, 6);
            this.frundGeneratorView.Name = "frundGeneratorView";
            this.frundGeneratorView.Size = new System.Drawing.Size(560, 213);
            this.frundGeneratorView.TabIndex = 0;
            // 
            // logView
            // 
            this.logView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logView.Location = new System.Drawing.Point(12, 299);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(554, 131);
            this.logView.TabIndex = 3;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 455);
            this.Controls.Add(this.selectedServoView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.logView);
            this.Name = "MainView";
            this.Text = "Управление роботом Гексаподом (Hexapod Robot Control)";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrundGeneratorProject.Views.FrundGeneratorView frundGeneratorView;
        private GateGeneratorProject.Views.GateGeneratorView gateGeneratorView;
        private Views.LogView logView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton updateListPortsButton;
        private System.Windows.Forms.ToolStripComboBox listPortsBox;
        private System.Windows.Forms.ToolStripButton connectButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionState;
        private Views.ServousListView servousListView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Views.SelectedServoView selectedServoView;
    }
}

