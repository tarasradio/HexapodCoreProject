﻿namespace HexapodGUIProject
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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.updateListPortsButton = new System.Windows.Forms.ToolStripButton();
            this.portsListBox = new System.Windows.Forms.ToolStripComboBox();
            this.connectButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.sourcesListBox = new System.Windows.Forms.ToolStripComboBox();
            this.selectGeneratorButton = new System.Windows.Forms.ToolStripButton();
            this.terminateGeneratorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.goToStartButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ServosTabPage = new System.Windows.Forms.TabPage();
            this.servousListView = new HexapodGUIProject.Views.ServousListView();
            this.FrundGeneratorTabPage = new System.Windows.Forms.TabPage();
            this.frundGeneratorView = new FrundGeneratorProject.Views.FrundGeneratorView();
            this.RealtimeGeneratorTabPage = new System.Windows.Forms.TabPage();
            this.realtimeGeneratorView = new RealtimeGeneratorProject.Views.RealtimeGeneratorView();
            this.selectedServoView = new HexapodGUIProject.Views.SelectedServoView();
            this.logView = new HexapodGUIProject.Views.LogView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ServosTabPage.SuspendLayout();
            this.FrundGeneratorTabPage.SuspendLayout();
            this.RealtimeGeneratorTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.updateListPortsButton,
            this.portsListBox,
            this.connectButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.sourcesListBox,
            this.selectGeneratorButton,
            this.terminateGeneratorButton,
            this.toolStripSeparator2,
            this.goToStartButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(794, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
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
            this.updateListPortsButton.Text = "Обновить список портов";
            this.updateListPortsButton.Click += new System.EventHandler(this.updateListPortsButton_Click);
            // 
            // portsListBox
            // 
            this.portsListBox.Name = "portsListBox";
            this.portsListBox.Size = new System.Drawing.Size(121, 39);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 36);
            this.toolStripLabel1.Text = "Генератор";
            // 
            // sourcesListBox
            // 
            this.sourcesListBox.Name = "sourcesListBox";
            this.sourcesListBox.Size = new System.Drawing.Size(121, 39);
            // 
            // selectGeneratorButton
            // 
            this.selectGeneratorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectGeneratorButton.Image = ((System.Drawing.Image)(resources.GetObject("selectGeneratorButton.Image")));
            this.selectGeneratorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectGeneratorButton.Name = "selectGeneratorButton";
            this.selectGeneratorButton.Size = new System.Drawing.Size(99, 36);
            this.selectGeneratorButton.Text = "Переключиться";
            this.selectGeneratorButton.Click += new System.EventHandler(this.selectGeneratorButton_Click);
            // 
            // terminateGeneratorButton
            // 
            this.terminateGeneratorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.terminateGeneratorButton.Image = ((System.Drawing.Image)(resources.GetObject("terminateGeneratorButton.Image")));
            this.terminateGeneratorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.terminateGeneratorButton.Name = "terminateGeneratorButton";
            this.terminateGeneratorButton.Size = new System.Drawing.Size(75, 36);
            this.terminateGeneratorButton.Text = "Остановить";
            this.terminateGeneratorButton.Click += new System.EventHandler(this.terminateGeneratorButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // goToStartButton
            // 
            this.goToStartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.goToStartButton.Image = ((System.Drawing.Image)(resources.GetObject("goToStartButton.Image")));
            this.goToStartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goToStartButton.Name = "goToStartButton";
            this.goToStartButton.Size = new System.Drawing.Size(76, 36);
            this.goToStartButton.Text = "В стартовое";
            this.goToStartButton.Click += new System.EventHandler(this.goToStartButton_Click);
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
            this.tabControl1.Controls.Add(this.ServosTabPage);
            this.tabControl1.Controls.Add(this.FrundGeneratorTabPage);
            this.tabControl1.Controls.Add(this.RealtimeGeneratorTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 251);
            this.tabControl1.TabIndex = 7;
            // 
            // ServosTabPage
            // 
            this.ServosTabPage.Controls.Add(this.servousListView);
            this.ServosTabPage.Location = new System.Drawing.Point(4, 22);
            this.ServosTabPage.Name = "ServosTabPage";
            this.ServosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ServosTabPage.Size = new System.Drawing.Size(546, 225);
            this.ServosTabPage.TabIndex = 0;
            this.ServosTabPage.Text = "Таблица приводов";
            this.ServosTabPage.UseVisualStyleBackColor = true;
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
            // FrundGeneratorTabPage
            // 
            this.FrundGeneratorTabPage.Controls.Add(this.frundGeneratorView);
            this.FrundGeneratorTabPage.Location = new System.Drawing.Point(4, 22);
            this.FrundGeneratorTabPage.Name = "FrundGeneratorTabPage";
            this.FrundGeneratorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FrundGeneratorTabPage.Size = new System.Drawing.Size(546, 225);
            this.FrundGeneratorTabPage.TabIndex = 1;
            this.FrundGeneratorTabPage.Text = "FRUND Generator (Files)";
            this.FrundGeneratorTabPage.UseVisualStyleBackColor = true;
            // 
            // frundGeneratorView
            // 
            this.frundGeneratorView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frundGeneratorView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frundGeneratorView.Location = new System.Drawing.Point(6, 6);
            this.frundGeneratorView.Name = "frundGeneratorView";
            this.frundGeneratorView.Size = new System.Drawing.Size(534, 213);
            this.frundGeneratorView.TabIndex = 0;
            // 
            // RealtimeGeneratorTabPage
            // 
            this.RealtimeGeneratorTabPage.Controls.Add(this.realtimeGeneratorView);
            this.RealtimeGeneratorTabPage.Location = new System.Drawing.Point(4, 22);
            this.RealtimeGeneratorTabPage.Name = "RealtimeGeneratorTabPage";
            this.RealtimeGeneratorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RealtimeGeneratorTabPage.Size = new System.Drawing.Size(546, 225);
            this.RealtimeGeneratorTabPage.TabIndex = 2;
            this.RealtimeGeneratorTabPage.Text = "Realtime Generator";
            this.RealtimeGeneratorTabPage.UseVisualStyleBackColor = true;
            // 
            // realtimeGeneratorView
            // 
            this.realtimeGeneratorView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.realtimeGeneratorView.Location = new System.Drawing.Point(6, 6);
            this.realtimeGeneratorView.Name = "realtimeGeneratorView";
            this.realtimeGeneratorView.Size = new System.Drawing.Size(534, 213);
            this.realtimeGeneratorView.TabIndex = 0;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ServosTabPage.ResumeLayout(false);
            this.FrundGeneratorTabPage.ResumeLayout(false);
            this.RealtimeGeneratorTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrundGeneratorProject.Views.FrundGeneratorView frundGeneratorView;
        private Views.LogView logView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton updateListPortsButton;
        private System.Windows.Forms.ToolStripComboBox portsListBox;
        private System.Windows.Forms.ToolStripButton connectButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionState;
        private Views.ServousListView servousListView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ServosTabPage;
        private System.Windows.Forms.TabPage FrundGeneratorTabPage;
        private Views.SelectedServoView selectedServoView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox sourcesListBox;
        private System.Windows.Forms.ToolStripButton selectGeneratorButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton terminateGeneratorButton;
        private System.Windows.Forms.ToolStripButton goToStartButton;
        private System.Windows.Forms.TabPage RealtimeGeneratorTabPage;
        private RealtimeGeneratorProject.Views.RealtimeGeneratorView realtimeGeneratorView;
    }
}

