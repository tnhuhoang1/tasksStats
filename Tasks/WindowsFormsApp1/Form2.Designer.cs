namespace WindowsFormsApp1 {
    partial class AddTaskForm {
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.taskDesTextBox = new System.Windows.Forms.TextBox();
            this.startFileTextBox = new System.Windows.Forms.TextBox();
            this.repeatCheckBox = new System.Windows.Forms.CheckBox();
            this.hourBox = new System.Windows.Forms.ComboBox();
            this.secondBox = new System.Windows.Forms.ComboBox();
            this.minuteBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.intervalMinute = new System.Windows.Forms.ComboBox();
            this.intervalSecond = new System.Windows.Forms.ComboBox();
            this.intervalHour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(306, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(397, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start After";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Interval";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Repeat";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(141, 26);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(323, 20);
            this.taskNameTextBox.TabIndex = 8;
            // 
            // taskDesTextBox
            // 
            this.taskDesTextBox.Location = new System.Drawing.Point(141, 54);
            this.taskDesTextBox.Name = "taskDesTextBox";
            this.taskDesTextBox.Size = new System.Drawing.Size(323, 20);
            this.taskDesTextBox.TabIndex = 9;
            // 
            // startFileTextBox
            // 
            this.startFileTextBox.Location = new System.Drawing.Point(141, 81);
            this.startFileTextBox.Name = "startFileTextBox";
            this.startFileTextBox.Size = new System.Drawing.Size(323, 20);
            this.startFileTextBox.TabIndex = 10;
            this.startFileTextBox.TabStop = false;
            this.startFileTextBox.Click += new System.EventHandler(this.startFileTextBox_Click);
            // 
            // repeatCheckBox
            // 
            this.repeatCheckBox.AutoSize = true;
            this.repeatCheckBox.Location = new System.Drawing.Point(141, 160);
            this.repeatCheckBox.Name = "repeatCheckBox";
            this.repeatCheckBox.Size = new System.Drawing.Size(15, 14);
            this.repeatCheckBox.TabIndex = 14;
            this.repeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // hourBox
            // 
            this.hourBox.FormattingEnabled = true;
            this.hourBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.hourBox.Location = new System.Drawing.Point(141, 107);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(115, 21);
            this.hourBox.TabIndex = 16;
            this.hourBox.Text = "Hours";
            // 
            // secondBox
            // 
            this.secondBox.FormattingEnabled = true;
            this.secondBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.secondBox.Location = new System.Drawing.Point(364, 107);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(100, 21);
            this.secondBox.TabIndex = 17;
            this.secondBox.Text = "Seconds";
            // 
            // minuteBox
            // 
            this.minuteBox.FormattingEnabled = true;
            this.minuteBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minuteBox.Location = new System.Drawing.Point(262, 107);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(96, 21);
            this.minuteBox.TabIndex = 18;
            this.minuteBox.Text = "Minutes";
            // 
            // intervalMinute
            // 
            this.intervalMinute.FormattingEnabled = true;
            this.intervalMinute.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.intervalMinute.Location = new System.Drawing.Point(262, 133);
            this.intervalMinute.Name = "intervalMinute";
            this.intervalMinute.Size = new System.Drawing.Size(96, 21);
            this.intervalMinute.TabIndex = 21;
            this.intervalMinute.Text = "Minutes";
            // 
            // intervalSecond
            // 
            this.intervalSecond.FormattingEnabled = true;
            this.intervalSecond.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.intervalSecond.Location = new System.Drawing.Point(364, 133);
            this.intervalSecond.Name = "intervalSecond";
            this.intervalSecond.Size = new System.Drawing.Size(100, 21);
            this.intervalSecond.TabIndex = 20;
            this.intervalSecond.Text = "Seconds";
            // 
            // intervalHour
            // 
            this.intervalHour.FormattingEnabled = true;
            this.intervalHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.intervalHour.Location = new System.Drawing.Point(141, 133);
            this.intervalHour.Name = "intervalHour";
            this.intervalHour.Size = new System.Drawing.Size(115, 21);
            this.intervalHour.TabIndex = 19;
            this.intervalHour.Text = "Hours";
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.intervalMinute);
            this.Controls.Add(this.intervalSecond);
            this.Controls.Add(this.intervalHour);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.repeatCheckBox);
            this.Controls.Add(this.startFileTextBox);
            this.Controls.Add(this.taskDesTextBox);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "AddTaskForm";
            this.Text = "AddTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.TextBox taskDesTextBox;
        private System.Windows.Forms.TextBox startFileTextBox;
        private System.Windows.Forms.CheckBox repeatCheckBox;
        private System.Windows.Forms.ComboBox hourBox;
        private System.Windows.Forms.ComboBox secondBox;
        private System.Windows.Forms.ComboBox minuteBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox intervalMinute;
        private System.Windows.Forms.ComboBox intervalSecond;
        private System.Windows.Forms.ComboBox intervalHour;
    }
}