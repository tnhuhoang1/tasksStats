using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class TaskForm : Form {

        private LeftNavController leftNavController = new LeftNavController();
        private Thread counterThread;
        public TaskForm() {
            InitializeComponent();
        }




        private void TaskForm_Load(object sender, EventArgs e) {
        
        }

        private async void mainTaskPanel_Layout(object sender, LayoutEventArgs e) {
            CounterThread cThread = new CounterThread();
/*            counterThread = new Thread(cThread.counting);
            counterThread.Start(counterPanel);
            cpuProgress.Value = 80;*/

            await Task.Factory.StartNew(() => cThread.counting(counterPanel), TaskCreationOptions.LongRunning);
        }




        // -- nav
        private void taskNav_Click(object sender, EventArgs e) {
            if (leftNavController.navigateTo(0)) {
                changeLayer();
            }
        }
        private void scheduleNav_Click(object sender, EventArgs e) {
            if (leftNavController.navigateTo(1)) {
                changeLayer();
            }
        }

        private void statsNav_Click(object sender, EventArgs e) {
            if (leftNavController.navigateTo(2)) {
                changeLayer();
            }
        }



        private void changeLayer() {
            disableAllLayer();
            enableNavLayer(leftNavController.getCurrentPosition());
        }

        private void disableAllLayer() {
            taskNav.BackColor = Color.White;
            taskNav.BorderStyle = BorderStyle.None;
            
            scheduleNav.BackColor = Color.White;
            scheduleNav.BorderStyle = BorderStyle.None;

            statsNav.BackColor = Color.White;
            statsNav.BorderStyle = BorderStyle.None;
        }

        private void enableNavLayer(int pos) {
            switch (pos) {
                case 0:
                    taskNav.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                    taskNav.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 1:
                    scheduleNav.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                    scheduleNav.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 2:
                    statsNav.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                    statsNav.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
        }
        // ++ nav
        // -- top nav
        private void foregroundPannel_Click(object sender, EventArgs e) {
            changeTopNav(1);
        }

        private void backgroundPanel_Click(object sender, EventArgs e) {
            changeTopNav(2);
        }

        private void changeTopNav(int pos) {
            if (leftNavController.changeTopNav(pos)) {
                switch (pos) {
                    case 1: {
                            foregroundPannel.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
                            foregroundPannel.BorderStyle = BorderStyle.Fixed3D;
                            foregroundCounterLabel.ForeColor = Color.White;
                            foregroundLabel.ForeColor = Color.White;

                            backgroundPanel.BackColor = System.Drawing.Color.White;
                            backgroundPanel.BorderStyle = BorderStyle.None;
                            backgroundCounterLabel.ForeColor = Color.Black;
                            backgroundLabel.ForeColor = Color.Black;

                            break;
                        }
                    case 2: {
                            backgroundPanel.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
                            backgroundPanel.BorderStyle = BorderStyle.Fixed3D;
                            backgroundCounterLabel.ForeColor = Color.White;
                            backgroundLabel.ForeColor = Color.White;

                            foregroundPannel.BackColor = System.Drawing.Color.White;
                            foregroundPannel.BorderStyle = BorderStyle.None;
                            foregroundCounterLabel.ForeColor = Color.Black;
                            foregroundLabel.ForeColor = Color.Black;

                            break;
                        }
                }
            }
            
        }



        // ++ top nav



        // helper
        private void getAllProcesses() {
            /*            Process[] processList = Process.GetProcesses();
                        foreach(Process p in processList) {
                            Debug.WriteLine(p.ProcessName +"\t"+ p.Id.ToString() + "\t" + p.BasePriority.ToString() + "\t" + p.StartInfo.FileName.ToString());
                        }*/

            ProcessUtils.getForegroundProcess();
            foreach(Process process in Process.GetProcesses()) {
                if (!String.IsNullOrEmpty(process.MainWindowTitle)) {
                    Debug.WriteLine("Process: {0} Id: {1} Window title: {2}", process.ProcessName, process.Id, process.MainWindowTitle);
                }
            }
        }

        private void TaskForm_Leave(object sender, EventArgs e) {
            MessageBox.Show("leave");
        }

    }

    class ProcessUtils {
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public static Process getForegroundProcess() {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            Debug.WriteLine(p.ProcessName);
            return p;
        }

    }

    class LeftNavController {
        private static int navPos = 0;
        private static int topNav = 0;
        public bool navigateTo(int pos) {
            if(navPos == pos) {
                return false;
            }
            navPos = pos;
            return true;
        }
        
        public int getCurrentPosition() {
            return navPos;
        }

        public bool changeTopNav(int pos) {
            if (topNav == pos) {
                return false;
            }
            topNav = pos;
            return true;
        }

    }

    class CounterThread {
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        public void counting(object obj) {

            try {
                Panel counterPanel = (Panel)obj;
                ProgressBar ramProgress = (ProgressBar) counterPanel.Controls.Find("ramPanel", false)[0].Controls.Find("ramProgress", false)[0];
                ProgressBar cpuProgress = (ProgressBar) counterPanel.Controls.Find("cpuPanel", false)[0].Controls.Find("cpuProgress", false)[0];
                Label ramCounterLabel = (Label)counterPanel.Controls.Find("ramPanel", false)[0].Controls.Find("ramCounterLabel", false)[0];
                Label cpuCounterLabel = (Label)counterPanel.Controls.Find("cpuPanel", false)[0].Controls.Find("cpuCounterLabel", false)[0];
                while (true) {
                    cpuProgress.Invoke(new Action(() => cpuProgress.Value = getCpuCounter()));
                    ramCounterLabel.Invoke(new Action(() => ramCounterLabel.Text = getRamCounter() + " %"));
                    cpuCounterLabel.Invoke(new Action(() => cpuCounterLabel.Text = getCpuCounter() + " %"));
                    logPerformance();
                    Thread.Sleep(500);
                }
            } catch(Exception e) {
                Debug.WriteLine(e.StackTrace);
            }


            
        }
        public void count(ProgressBar p) {
            if (p.InvokeRequired) {
                p.Invoke(new Action(() => p.Value = 10));
            }
        }

        private int getCpuCounter() {
            return (int)cpuCounter.NextValue();
        }

        private int getRamCounter() {
            return (int)ramCounter.NextValue();
        }

        private void logPerformance() {
            Debug.WriteLine("Cpu: " + cpuCounter.NextValue() + " %");
            Debug.WriteLine("Ram: " + ramCounter.NextValue() + " MB");
        }
    }
}
