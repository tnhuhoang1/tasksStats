using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    partial class TaskForm {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.leftSideNavPanel = new System.Windows.Forms.Panel();
            this.statsNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.scheduleNav = new System.Windows.Forms.Panel();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.taskNav = new System.Windows.Forms.Panel();
            this.taskLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.scheduleTaskListView = new System.Windows.Forms.ListView();
            this.taskNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskDescHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startAfterHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.intervalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repeatHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.mainTaskPanel = new System.Windows.Forms.Panel();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.processDetailListView = new System.Windows.Forms.ListView();
            this.processNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pidHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topMainPanel = new System.Windows.Forms.Panel();
            this.counterPanel = new System.Windows.Forms.Panel();
            this.cpuPanel = new System.Windows.Forms.Panel();
            this.cpuCounterLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpuProgress = new System.Windows.Forms.ProgressBar();
            this.cpuPicture = new System.Windows.Forms.PictureBox();
            this.ramPanel = new System.Windows.Forms.Panel();
            this.ramCounterLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ramProgress = new System.Windows.Forms.ProgressBar();
            this.ramPicture = new System.Windows.Forms.PictureBox();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.backgroundCounterLabel = new System.Windows.Forms.Label();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.foregroundPannel = new System.Windows.Forms.Panel();
            this.foregroundLabel = new System.Windows.Forms.Label();
            this.foregroundCounterLabel = new System.Windows.Forms.Label();
            this.pictureForeground = new System.Windows.Forms.PictureBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.leftSideNavPanel.SuspendLayout();
            this.statsNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.scheduleNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.taskNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.schedulePanel.SuspendLayout();
            this.header.SuspendLayout();
            this.mainTaskPanel.SuspendLayout();
            this.mainContentPanel.SuspendLayout();
            this.topMainPanel.SuspendLayout();
            this.counterPanel.SuspendLayout();
            this.cpuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPicture)).BeginInit();
            this.ramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramPicture)).BeginInit();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            this.foregroundPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForeground)).BeginInit();
            this.SuspendLayout();
            // 
            // leftSideNavPanel
            // 
            this.leftSideNavPanel.BackColor = System.Drawing.Color.White;
            this.leftSideNavPanel.Controls.Add(this.statsNav);
            this.leftSideNavPanel.Controls.Add(this.scheduleNav);
            this.leftSideNavPanel.Controls.Add(this.taskNav);
            this.leftSideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.leftSideNavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftSideNavPanel.Name = "leftSideNavPanel";
            this.leftSideNavPanel.Size = new System.Drawing.Size(256, 480);
            this.leftSideNavPanel.TabIndex = 1;
            // 
            // statsNav
            // 
            this.statsNav.BackColor = System.Drawing.Color.Transparent;
            this.statsNav.Controls.Add(this.label1);
            this.statsNav.Controls.Add(this.pictureBox3);
            this.statsNav.Location = new System.Drawing.Point(12, 128);
            this.statsNav.Margin = new System.Windows.Forms.Padding(16);
            this.statsNav.Name = "statsNav";
            this.statsNav.Size = new System.Drawing.Size(234, 50);
            this.statsNav.TabIndex = 3;
            this.statsNav.Visible = false;
            this.statsNav.Click += new System.EventHandler(this.statsNav_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statistics";
            this.label1.Click += new System.EventHandler(this.statsNav_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.statsNav_Click);
            // 
            // scheduleNav
            // 
            this.scheduleNav.BackColor = System.Drawing.Color.Transparent;
            this.scheduleNav.Controls.Add(this.scheduleLabel);
            this.scheduleNav.Controls.Add(this.pictureBox2);
            this.scheduleNav.Location = new System.Drawing.Point(12, 71);
            this.scheduleNav.Margin = new System.Windows.Forms.Padding(16);
            this.scheduleNav.Name = "scheduleNav";
            this.scheduleNav.Size = new System.Drawing.Size(234, 50);
            this.scheduleNav.TabIndex = 2;
            this.scheduleNav.Click += new System.EventHandler(this.scheduleNav_Click);
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.scheduleLabel.Location = new System.Drawing.Point(44, 9);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Padding = new System.Windows.Forms.Padding(8);
            this.scheduleLabel.Size = new System.Drawing.Size(82, 32);
            this.scheduleLabel.TabIndex = 1;
            this.scheduleLabel.Text = "Schedule";
            this.scheduleLabel.Click += new System.EventHandler(this.scheduleNav_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.scheduleNav_Click);
            // 
            // taskNav
            // 
            this.taskNav.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.taskNav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taskNav.Controls.Add(this.taskLabel);
            this.taskNav.Controls.Add(this.pictureBox1);
            this.taskNav.Location = new System.Drawing.Point(12, 12);
            this.taskNav.Margin = new System.Windows.Forms.Padding(16);
            this.taskNav.Name = "taskNav";
            this.taskNav.Size = new System.Drawing.Size(234, 50);
            this.taskNav.TabIndex = 1;
            this.taskNav.Click += new System.EventHandler(this.taskNav_Click);
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.taskLabel.Location = new System.Drawing.Point(44, 9);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Padding = new System.Windows.Forms.Padding(8);
            this.taskLabel.Size = new System.Drawing.Size(60, 32);
            this.taskLabel.TabIndex = 1;
            this.taskLabel.Text = "Tasks";
            this.taskLabel.Click += new System.EventHandler(this.taskNav_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.taskNav_Click);
            // 
            // schedulePanel
            // 
            this.schedulePanel.BackColor = System.Drawing.Color.MistyRose;
            this.schedulePanel.Controls.Add(this.scheduleTaskListView);
            this.schedulePanel.Controls.Add(this.header);
            this.schedulePanel.Location = new System.Drawing.Point(274, 2);
            this.schedulePanel.Margin = new System.Windows.Forms.Padding(2);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(666, 440);
            this.schedulePanel.TabIndex = 6;
            this.schedulePanel.Visible = false;
            this.schedulePanel.VisibleChanged += new System.EventHandler(this.schedulePanel_VisibleChanged);
            // 
            // scheduleTaskListView
            // 
            this.scheduleTaskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskNameHeader,
            this.taskDescHeader,
            this.taskFile,
            this.startAfterHeader,
            this.intervalHeader,
            this.repeatHeader});
            this.scheduleTaskListView.HideSelection = false;
            this.scheduleTaskListView.Location = new System.Drawing.Point(23, 77);
            this.scheduleTaskListView.Name = "scheduleTaskListView";
            this.scheduleTaskListView.Size = new System.Drawing.Size(596, 322);
            this.scheduleTaskListView.TabIndex = 4;
            this.scheduleTaskListView.UseCompatibleStateImageBehavior = false;
            this.scheduleTaskListView.View = System.Windows.Forms.View.Details;
            // 
            // taskNameHeader
            // 
            this.taskNameHeader.Text = "Task Name";
            this.taskNameHeader.Width = 97;
            // 
            // taskDescHeader
            // 
            this.taskDescHeader.Text = "Task Description";
            this.taskDescHeader.Width = 130;
            // 
            // taskFile
            // 
            this.taskFile.Text = "Task File";
            this.taskFile.Width = 83;
            // 
            // startAfterHeader
            // 
            this.startAfterHeader.Text = "Start After(s)";
            this.startAfterHeader.Width = 123;
            // 
            // intervalHeader
            // 
            this.intervalHeader.Text = "Interval(s)";
            this.intervalHeader.Width = 99;
            // 
            // repeatHeader
            // 
            this.repeatHeader.Text = "Repeat";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.deleteButton);
            this.header.Controls.Add(this.addTaskButton);
            this.header.Controls.Add(this.cancelButton);
            this.header.Controls.Add(this.applyButton);
            this.header.Location = new System.Drawing.Point(22, 26);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(596, 39);
            this.header.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(506, 2);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(42, 33);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "x";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.Orange;
            this.addTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.Location = new System.Drawing.Point(552, 2);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(42, 33);
            this.addTaskButton.TabIndex = 5;
            this.addTaskButton.Text = "+";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Honeydew;
            this.cancelButton.Enabled = false;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(125, 1);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 36);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(0, 1);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(121, 36);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // mainTaskPanel
            // 
            this.mainTaskPanel.Controls.Add(this.mainContentPanel);
            this.mainTaskPanel.Controls.Add(this.topMainPanel);
            this.mainTaskPanel.Location = new System.Drawing.Point(265, 12);
            this.mainTaskPanel.Name = "mainTaskPanel";
            this.mainTaskPanel.Size = new System.Drawing.Size(675, 417);
            this.mainTaskPanel.TabIndex = 3;
            this.mainTaskPanel.VisibleChanged += new System.EventHandler(this.mainTaskPanel_VisibleChanged);
            this.mainTaskPanel.Layout += new System.Windows.Forms.LayoutEventHandler(this.mainTaskPanel_Layout);
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Controls.Add(this.processDetailListView);
            this.mainContentPanel.Location = new System.Drawing.Point(7, 139);
            this.mainContentPanel.Margin = new System.Windows.Forms.Padding(16);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Padding = new System.Windows.Forms.Padding(16);
            this.mainContentPanel.Size = new System.Drawing.Size(663, 291);
            this.mainContentPanel.TabIndex = 4;
            // 
            // processDetailListView
            // 
            this.processDetailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processNameHeader,
            this.pidHeader,
            this.statusHeader,
            this.usernameHeader,
            this.memoryHeader,
            this.descriptionHeader});
            this.processDetailListView.HideSelection = false;
            this.processDetailListView.Location = new System.Drawing.Point(0, 0);
            this.processDetailListView.Name = "processDetailListView";
            this.processDetailListView.Size = new System.Drawing.Size(663, 275);
            this.processDetailListView.TabIndex = 0;
            this.processDetailListView.UseCompatibleStateImageBehavior = false;
            this.processDetailListView.View = System.Windows.Forms.View.Details;
            // 
            // processNameHeader
            // 
            this.processNameHeader.Text = "Process Name";
            this.processNameHeader.Width = 120;
            // 
            // pidHeader
            // 
            this.pidHeader.Text = "PID";
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 100;
            // 
            // usernameHeader
            // 
            this.usernameHeader.Text = "Username";
            this.usernameHeader.Width = 100;
            // 
            // memoryHeader
            // 
            this.memoryHeader.Text = "Memory";
            this.memoryHeader.Width = 100;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.Width = 200;
            // 
            // topMainPanel
            // 
            this.topMainPanel.Controls.Add(this.counterPanel);
            this.topMainPanel.Controls.Add(this.backgroundPanel);
            this.topMainPanel.Controls.Add(this.foregroundPannel);
            this.topMainPanel.Location = new System.Drawing.Point(7, 11);
            this.topMainPanel.Margin = new System.Windows.Forms.Padding(16);
            this.topMainPanel.Name = "topMainPanel";
            this.topMainPanel.Padding = new System.Windows.Forms.Padding(16);
            this.topMainPanel.Size = new System.Drawing.Size(663, 120);
            this.topMainPanel.TabIndex = 3;
            // 
            // counterPanel
            // 
            this.counterPanel.Controls.Add(this.cpuPanel);
            this.counterPanel.Controls.Add(this.ramPanel);
            this.counterPanel.Location = new System.Drawing.Point(263, 9);
            this.counterPanel.Name = "counterPanel";
            this.counterPanel.Size = new System.Drawing.Size(397, 100);
            this.counterPanel.TabIndex = 2;
            // 
            // cpuPanel
            // 
            this.cpuPanel.Controls.Add(this.cpuCounterLabel);
            this.cpuPanel.Controls.Add(this.label4);
            this.cpuPanel.Controls.Add(this.cpuProgress);
            this.cpuPanel.Controls.Add(this.cpuPicture);
            this.cpuPanel.Location = new System.Drawing.Point(3, 57);
            this.cpuPanel.Name = "cpuPanel";
            this.cpuPanel.Size = new System.Drawing.Size(394, 40);
            this.cpuPanel.TabIndex = 4;
            // 
            // cpuCounterLabel
            // 
            this.cpuCounterLabel.AutoSize = true;
            this.cpuCounterLabel.Location = new System.Drawing.Point(352, 6);
            this.cpuCounterLabel.Name = "cpuCounterLabel";
            this.cpuCounterLabel.Size = new System.Drawing.Size(30, 13);
            this.cpuCounterLabel.TabIndex = 7;
            this.cpuCounterLabel.Text = "52 %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPU";
            // 
            // cpuProgress
            // 
            this.cpuProgress.Location = new System.Drawing.Point(52, 3);
            this.cpuProgress.Name = "cpuProgress";
            this.cpuProgress.Size = new System.Drawing.Size(286, 16);
            this.cpuProgress.Step = 100;
            this.cpuProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpuProgress.TabIndex = 3;
            this.cpuProgress.Value = 20;
            // 
            // cpuPicture
            // 
            this.cpuPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cpuPicture.Image = ((System.Drawing.Image)(resources.GetObject("cpuPicture.Image")));
            this.cpuPicture.Location = new System.Drawing.Point(0, 0);
            this.cpuPicture.Margin = new System.Windows.Forms.Padding(0);
            this.cpuPicture.Name = "cpuPicture";
            this.cpuPicture.Size = new System.Drawing.Size(40, 40);
            this.cpuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpuPicture.TabIndex = 1;
            this.cpuPicture.TabStop = false;
            // 
            // ramPanel
            // 
            this.ramPanel.Controls.Add(this.ramCounterLabel);
            this.ramPanel.Controls.Add(this.label5);
            this.ramPanel.Controls.Add(this.ramProgress);
            this.ramPanel.Controls.Add(this.ramPicture);
            this.ramPanel.Location = new System.Drawing.Point(3, 3);
            this.ramPanel.Name = "ramPanel";
            this.ramPanel.Size = new System.Drawing.Size(394, 40);
            this.ramPanel.TabIndex = 3;
            // 
            // ramCounterLabel
            // 
            this.ramCounterLabel.AutoSize = true;
            this.ramCounterLabel.Location = new System.Drawing.Point(352, 4);
            this.ramCounterLabel.Name = "ramCounterLabel";
            this.ramCounterLabel.Size = new System.Drawing.Size(30, 13);
            this.ramCounterLabel.TabIndex = 6;
            this.ramCounterLabel.Text = "52 %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "RAM";
            // 
            // ramProgress
            // 
            this.ramProgress.Location = new System.Drawing.Point(52, 3);
            this.ramProgress.Name = "ramProgress";
            this.ramProgress.Size = new System.Drawing.Size(286, 16);
            this.ramProgress.Step = 100;
            this.ramProgress.TabIndex = 2;
            this.ramProgress.Value = 52;
            // 
            // ramPicture
            // 
            this.ramPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ramPicture.Image = ((System.Drawing.Image)(resources.GetObject("ramPicture.Image")));
            this.ramPicture.Location = new System.Drawing.Point(0, -1);
            this.ramPicture.Margin = new System.Windows.Forms.Padding(0);
            this.ramPicture.Name = "ramPicture";
            this.ramPicture.Size = new System.Drawing.Size(40, 40);
            this.ramPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ramPicture.TabIndex = 1;
            this.ramPicture.TabStop = false;
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.White;
            this.backgroundPanel.Controls.Add(this.backgroundLabel);
            this.backgroundPanel.Controls.Add(this.backgroundCounterLabel);
            this.backgroundPanel.Controls.Add(this.pictureBackground);
            this.backgroundPanel.Location = new System.Drawing.Point(143, 9);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(96, 100);
            this.backgroundPanel.TabIndex = 1;
            this.backgroundPanel.Click += new System.EventHandler(this.backgroundPanel_Click);
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backgroundLabel.Location = new System.Drawing.Point(11, 74);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(84, 17);
            this.backgroundLabel.TabIndex = 4;
            this.backgroundLabel.Text = "Background";
            this.backgroundLabel.Click += new System.EventHandler(this.backgroundPanel_Click);
            // 
            // backgroundCounterLabel
            // 
            this.backgroundCounterLabel.AutoSize = true;
            this.backgroundCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundCounterLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backgroundCounterLabel.Location = new System.Drawing.Point(38, 50);
            this.backgroundCounterLabel.Name = "backgroundCounterLabel";
            this.backgroundCounterLabel.Size = new System.Drawing.Size(24, 17);
            this.backgroundCounterLabel.TabIndex = 3;
            this.backgroundCounterLabel.Text = "32";
            this.backgroundCounterLabel.Click += new System.EventHandler(this.backgroundPanel_Click);
            // 
            // pictureBackground
            // 
            this.pictureBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBackground.Image")));
            this.pictureBackground.Location = new System.Drawing.Point(28, 4);
            this.pictureBackground.Name = "pictureBackground";
            this.pictureBackground.Size = new System.Drawing.Size(40, 40);
            this.pictureBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackground.TabIndex = 1;
            this.pictureBackground.TabStop = false;
            this.pictureBackground.Click += new System.EventHandler(this.backgroundPanel_Click);
            // 
            // foregroundPannel
            // 
            this.foregroundPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.foregroundPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.foregroundPannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foregroundPannel.Controls.Add(this.foregroundLabel);
            this.foregroundPannel.Controls.Add(this.foregroundCounterLabel);
            this.foregroundPannel.Controls.Add(this.pictureForeground);
            this.foregroundPannel.Location = new System.Drawing.Point(19, 9);
            this.foregroundPannel.Name = "foregroundPannel";
            this.foregroundPannel.Size = new System.Drawing.Size(96, 100);
            this.foregroundPannel.TabIndex = 0;
            this.foregroundPannel.Click += new System.EventHandler(this.foregroundPannel_Click);
            // 
            // foregroundLabel
            // 
            this.foregroundLabel.AutoSize = true;
            this.foregroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foregroundLabel.ForeColor = System.Drawing.Color.White;
            this.foregroundLabel.Location = new System.Drawing.Point(9, 74);
            this.foregroundLabel.Name = "foregroundLabel";
            this.foregroundLabel.Size = new System.Drawing.Size(82, 17);
            this.foregroundLabel.TabIndex = 2;
            this.foregroundLabel.Text = "Foreground";
            this.foregroundLabel.Click += new System.EventHandler(this.foregroundPannel_Click);
            // 
            // foregroundCounterLabel
            // 
            this.foregroundCounterLabel.AutoSize = true;
            this.foregroundCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foregroundCounterLabel.ForeColor = System.Drawing.Color.White;
            this.foregroundCounterLabel.Location = new System.Drawing.Point(36, 50);
            this.foregroundCounterLabel.Name = "foregroundCounterLabel";
            this.foregroundCounterLabel.Size = new System.Drawing.Size(24, 17);
            this.foregroundCounterLabel.TabIndex = 1;
            this.foregroundCounterLabel.Text = "32";
            this.foregroundCounterLabel.Click += new System.EventHandler(this.foregroundPannel_Click);
            // 
            // pictureForeground
            // 
            this.pictureForeground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureForeground.Image = ((System.Drawing.Image)(resources.GetObject("pictureForeground.Image")));
            this.pictureForeground.Location = new System.Drawing.Point(28, 4);
            this.pictureForeground.Margin = new System.Windows.Forms.Padding(0);
            this.pictureForeground.Name = "pictureForeground";
            this.pictureForeground.Size = new System.Drawing.Size(40, 40);
            this.pictureForeground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureForeground.TabIndex = 0;
            this.pictureForeground.TabStop = false;
            this.pictureForeground.Click += new System.EventHandler(this.foregroundPannel_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(944, 441);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.mainTaskPanel);
            this.Controls.Add(this.leftSideNavPanel);
            this.Name = "TaskForm";
            this.Text = "TasksStatistics";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.Leave += new System.EventHandler(this.TaskForm_Leave);
            this.leftSideNavPanel.ResumeLayout(false);
            this.statsNav.ResumeLayout(false);
            this.statsNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.scheduleNav.ResumeLayout(false);
            this.scheduleNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.taskNav.ResumeLayout(false);
            this.taskNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.schedulePanel.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.mainTaskPanel.ResumeLayout(false);
            this.mainContentPanel.ResumeLayout(false);
            this.topMainPanel.ResumeLayout(false);
            this.counterPanel.ResumeLayout(false);
            this.cpuPanel.ResumeLayout(false);
            this.cpuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPicture)).EndInit();
            this.ramPanel.ResumeLayout(false);
            this.ramPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramPicture)).EndInit();
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            this.foregroundPannel.ResumeLayout(false);
            this.foregroundPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForeground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel leftSideNavPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel taskNav;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Panel scheduleNav;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Panel statsNav;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel mainTaskPanel;
        private Panel mainContentPanel;
        private Panel topMainPanel;
        private Panel ramPanel;
        private Label ramCounterLabel;
        private Label label5;
        private ProgressBar ramProgress;
        private PictureBox ramPicture;
        private Panel cpuPanel;
        private Label cpuCounterLabel;
        private Label label4;
        private ProgressBar cpuProgress;
        private PictureBox cpuPicture;
        private Panel counterPanel;
        private Panel backgroundPanel;
        private Label backgroundLabel;
        private Label backgroundCounterLabel;
        private PictureBox pictureBackground;
        private Panel foregroundPannel;
        private Label foregroundLabel;
        private Label foregroundCounterLabel;
        private PictureBox pictureForeground;
        private ListView processDetailListView;
        private ColumnHeader processNameHeader;
        private ColumnHeader pidHeader;
        private ColumnHeader statusHeader;
        private ColumnHeader usernameHeader;
        private ColumnHeader memoryHeader;
        private ColumnHeader descriptionHeader;
        private Panel schedulePanel;
        private Panel header;
        private OpenFileDialog fileDialog;
        private Button cancelButton;
        private Button applyButton;
        private Button addTaskButton;
        private ListView scheduleTaskListView;
        private ColumnHeader taskNameHeader;
        private ColumnHeader taskDescHeader;
        private ColumnHeader taskFile;
        private ColumnHeader startAfterHeader;
        private ColumnHeader intervalHeader;
        private ColumnHeader repeatHeader;
        private Button deleteButton;
    }
}

