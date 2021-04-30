using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class AddTaskForm : Form {
        public bool isSuccess = false;
        public TimeSpan delayStart = TimeSpan.Zero;
        public TimeSpan timeInterval = TimeSpan.FromSeconds(10);
        public bool isRepeat = false;
        public string taskNameResult = "";
        public string taskDescResult = "";
        public string taskFileResult = "";
        public AddTaskForm() {
            InitializeComponent();
        }

        private void startFileTextBox_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
            if (!String.IsNullOrEmpty(openFileDialog.FileName)) {
                startFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(taskNameTextBox.Text) || String.IsNullOrEmpty(taskDesTextBox.Text) || String.IsNullOrEmpty(startFileTextBox.Text)) {
                MessageBox.Show("Khong de trong 3 o dau tien nhe");
                return;
            }

            if(!String.Equals("Hours", hourBox.Text)) {
                delayStart = delayStart.Add(TimeSpan.FromHours(double.Parse(hourBox.Text)));
            }
            if (!String.Equals("Minutes", minuteBox.Text)) {
                delayStart = delayStart.Add(TimeSpan.FromMinutes(double.Parse(minuteBox.Text)));
            }
            if (!String.Equals("Seconds", secondBox.Text)) {
                delayStart = delayStart.Add(TimeSpan.FromSeconds(double.Parse(secondBox.Text)));
            }

            if (!String.Equals("Hours", intervalHour.Text)) {
                timeInterval = timeInterval.Add(TimeSpan.FromHours(double.Parse(intervalHour.Text)));
            }
            if (!String.Equals("Minutes", intervalMinute.Text)) {
                timeInterval = timeInterval.Add(TimeSpan.FromMinutes(double.Parse(intervalMinute.Text)));
            }
            if (!String.Equals("Seconds", intervalSecond.Text)) {
                timeInterval = timeInterval.Add(TimeSpan.FromSeconds(double.Parse(intervalSecond.Text)));
            }

            if (repeatCheckBox.Checked) {
                isRepeat = true;
            }
            taskNameResult = taskNameTextBox.Text;
            taskDescResult = taskDesTextBox.Text;
            taskFileResult = startFileTextBox.Text;

            isSuccess = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) {



            this.Close();
        }
    }
}
