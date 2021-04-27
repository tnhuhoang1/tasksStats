using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
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
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.leftSideNavPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.scheduleNav = new System.Windows.Forms.Panel();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.taskNav = new System.Windows.Forms.Panel();
            this.taskLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topMainPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ramProgress = new System.Windows.Forms.ProgressBar();
            this.ramPicture = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpuProgress = new System.Windows.Forms.ProgressBar();
            this.cpuPicture = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.foregroundPannel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureForeground = new System.Windows.Forms.PictureBox();
            this.mainContentPanel.SuspendLayout();
            this.leftSideNavPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.scheduleNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.taskNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topMainPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramPicture)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPicture)).BeginInit();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            this.foregroundPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForeground)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Controls.Add(this.panel11);
            this.mainContentPanel.Controls.Add(this.panel10);
            this.mainContentPanel.Controls.Add(this.panel9);
            this.mainContentPanel.Controls.Add(this.panel8);
            this.mainContentPanel.Controls.Add(this.panel7);
            this.mainContentPanel.Location = new System.Drawing.Point(272, 137);
            this.mainContentPanel.Margin = new System.Windows.Forms.Padding(16);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Padding = new System.Windows.Forms.Padding(16);
            this.mainContentPanel.Size = new System.Drawing.Size(663, 291);
            this.mainContentPanel.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gray;
            this.panel11.Location = new System.Drawing.Point(522, 15);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(16);
            this.panel11.Size = new System.Drawing.Size(232, 128);
            this.panel11.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Location = new System.Drawing.Point(271, 151);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(16);
            this.panel10.Size = new System.Drawing.Size(232, 128);
            this.panel10.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(271, 15);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(16);
            this.panel9.Size = new System.Drawing.Size(232, 128);
            this.panel9.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(19, 151);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(16);
            this.panel8.Size = new System.Drawing.Size(232, 128);
            this.panel8.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(19, 15);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(16);
            this.panel7.Size = new System.Drawing.Size(232, 128);
            this.panel7.TabIndex = 1;
            // 
            // leftSideNavPanel
            // 
            this.leftSideNavPanel.BackColor = System.Drawing.Color.White;
            this.leftSideNavPanel.Controls.Add(this.panel1);
            this.leftSideNavPanel.Controls.Add(this.scheduleNav);
            this.leftSideNavPanel.Controls.Add(this.taskNav);
            this.leftSideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.leftSideNavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftSideNavPanel.Name = "leftSideNavPanel";
            this.leftSideNavPanel.Size = new System.Drawing.Size(256, 480);
            this.leftSideNavPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(12, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 50);
            this.panel1.TabIndex = 3;
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
            // 
            // topMainPanel
            // 
            this.topMainPanel.Controls.Add(this.panel5);
            this.topMainPanel.Controls.Add(this.panel6);
            this.topMainPanel.Controls.Add(this.panel4);
            this.topMainPanel.Controls.Add(this.backgroundPanel);
            this.topMainPanel.Controls.Add(this.foregroundPannel);
            this.topMainPanel.Location = new System.Drawing.Point(272, 12);
            this.topMainPanel.Margin = new System.Windows.Forms.Padding(16);
            this.topMainPanel.Name = "topMainPanel";
            this.topMainPanel.Padding = new System.Windows.Forms.Padding(16);
            this.topMainPanel.Size = new System.Drawing.Size(663, 120);
            this.topMainPanel.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.ramProgress);
            this.panel5.Controls.Add(this.ramPicture);
            this.panel5.Location = new System.Drawing.Point(263, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(394, 40);
            this.panel5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "52 %";
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
            // panel6
            // 
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.cpuProgress);
            this.panel6.Controls.Add(this.cpuPicture);
            this.panel6.Location = new System.Drawing.Point(263, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(394, 40);
            this.panel6.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "52 %";
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
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(263, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 100);
            this.panel4.TabIndex = 2;
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.White;
            this.backgroundPanel.Controls.Add(this.label8);
            this.backgroundPanel.Controls.Add(this.label9);
            this.backgroundPanel.Controls.Add(this.pictureBackground);
            this.backgroundPanel.Location = new System.Drawing.Point(143, 9);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(96, 100);
            this.backgroundPanel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Foreground";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(38, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "32";
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
            // 
            // foregroundPannel
            // 
            this.foregroundPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(148)))), ((int)(((byte)(244)))));
            this.foregroundPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.foregroundPannel.Controls.Add(this.label3);
            this.foregroundPannel.Controls.Add(this.label2);
            this.foregroundPannel.Controls.Add(this.pictureForeground);
            this.foregroundPannel.Location = new System.Drawing.Point(19, 9);
            this.foregroundPannel.Name = "foregroundPannel";
            this.foregroundPannel.Size = new System.Drawing.Size(96, 100);
            this.foregroundPannel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Foreground";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "32";
            // 
            // pictureForeground
            // 
            this.pictureForeground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureForeground.Image = ((System.Drawing.Image)(resources.GetObject("pictureForeground.Image")));
            this.pictureForeground.Location = new System.Drawing.Point(24, 4);
            this.pictureForeground.Margin = new System.Windows.Forms.Padding(0);
            this.pictureForeground.Name = "pictureForeground";
            this.pictureForeground.Size = new System.Drawing.Size(40, 40);
            this.pictureForeground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureForeground.TabIndex = 0;
            this.pictureForeground.TabStop = false;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(944, 441);
            this.Controls.Add(this.topMainPanel);
            this.Controls.Add(this.leftSideNavPanel);
            this.Controls.Add(this.mainContentPanel);
            this.Name = "TaskForm";
            this.Text = "TasksStatistics";
            this.mainContentPanel.ResumeLayout(false);
            this.leftSideNavPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.scheduleNav.ResumeLayout(false);
            this.scheduleNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.taskNav.ResumeLayout(false);
            this.taskNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topMainPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramPicture)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPicture)).EndInit();
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            this.foregroundPannel.ResumeLayout(false);
            this.foregroundPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForeground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Panel leftSideNavPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel taskNav;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Panel scheduleNav;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel topMainPanel;
        private Panel backgroundPanel;
        private Panel foregroundPannel;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private PictureBox pictureBackground;
        private PictureBox pictureForeground;
        private Label label2;
        private Label label3;
        private PictureBox cpuPicture;
        private PictureBox ramPicture;
        private Label label6;
        private Label label5;
        private ProgressBar ramProgress;
        private Label label7;
        private Label label4;
        private ProgressBar cpuProgress;
        private Label label8;
        private Label label9;
    }
}

