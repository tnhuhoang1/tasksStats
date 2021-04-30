using ASquare.WindowsTaskScheduler;
using ASquare.WindowsTaskScheduler.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class TaskForm : Form {

        private LeftNavController leftNavController = new LeftNavController();
        CounterThread cThread = new CounterThread();
        private ProcessUtils processUtils = new ProcessUtils();
        private bool isCounting = true;
        public TaskForm() {
            InitializeComponent();
        }




        private void TaskForm_Load(object sender, EventArgs e) {
            init();
            
        }

        private async void mainTaskPanel_Layout(object sender, LayoutEventArgs e) {
            
            
        }




        private async void init() {
            CancellationTokenSource source = leftNavController.getNewForegroundToken();
            await Task.Run(
                () => {
                    List<Process> list = getAllOpenProcess(Process.GetProcesses());
                    renderOpenProcessesOnListView(list.ToArray(), source.Token);
                }
            );

        }

        private List<Process> getAllOpenProcess(Process[] list) {
            List<Process> result = new List<Process>();
            foreach (Process process in list) {
                if (!String.IsNullOrEmpty(process.MainWindowTitle)) {
                    result.Add(process);
                }
            }
            return result;
        }

        private List<Process> getAllBackgroundProcess(Process[] list) {
            List<Process> result = new List<Process>();
            foreach (Process process in list) {
                if (String.IsNullOrEmpty(process.MainWindowTitle)) {
                    result.Add(process);
                }
            }
            return result;
        }


        public void renderForegroundCounterLabel(Process[] processList) {
            foregroundCounterLabel.Invoke(new Action(() => foregroundCounterLabel.Text = (processList.Length).ToString()));
        }
        public void renderBackgroundCounterLabel(Process[] processList) {
            foregroundCounterLabel.Invoke(new Action(() => backgroundCounterLabel.Text = (processList.Length).ToString()));
        }



        public void renderOpenProcessesOnListView(Process[] processList, CancellationToken cancellationToken) {
            processDetailListView.Invoke(new Action(() => processDetailListView.Items.Clear()));
            ImageList Imagelist = new ImageList();
            renderForegroundCounterLabel(processList);
            // Loop through the array of processes to show information of every process in your console
            try {
                foreach (Process process in processList) {
                    cancellationToken.ThrowIfCancellationRequested();
                    // Define the status from a boolean to a simple string
                    string status = (process.Responding == true ? "Responding" : "Not responding");

                    // Retrieve the object of extra information of the process (to retrieve Username and Description)
                    dynamic extraProcessInfo = GetProcessExtraInformation(process.Id);

                    // Create an array of string that will store the information to display in our 
                    string[] row = {
                    // 1 Process name
                    process.ProcessName,
                    // 2 Process ID
                    process.Id.ToString(),
                    // 3 Process status
                    status,
                    // 4 Username that started the process
                    extraProcessInfo.Username,
                    // 5 Memory usage
                    BytesToReadableValue(process.PrivateMemorySize64),
                    // 6 Description of the process
                    extraProcessInfo.Description
                };

                    //
                    // As not every process has an icon then, prevent the app from crash
                    try {
                        Imagelist.Images.Add(
                            // Add an unique Key as identifier for the icon (same as the ID of the process)
                            process.Id.ToString(),
                            // Add Icon to the List 
                            Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap()
                        );
                    } catch { }

                    // Create a new Item to add into the list view that expects the row of information as first argument
                    ListViewItem item = new ListViewItem(row) {
                        // Set the ImageIndex of the item as the same defined in the previous try-catch
                        ImageIndex = Imagelist.Images.IndexOfKey(process.Id.ToString())
                    };


                    // Add the Item
                    processDetailListView.Invoke(new Action(() => processDetailListView.Items.Add(item)));
                }
            } catch {
                Debug.WriteLine("Cancel foreground");
            }
            

            // Set the imagelist of your list view the previous created list :)
            processDetailListView.Invoke(new Action(() => processDetailListView.LargeImageList = Imagelist));
            processDetailListView.Invoke(new Action(() => processDetailListView.SmallImageList = Imagelist));
        }


        public ExpandoObject GetProcessExtraInformation(int processId) {
            // Query the Win32_Process
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            // Create a dynamic object to store some properties on it
            dynamic response = new ExpandoObject();
            response.Description = "";
            response.Username = "Unknown";

            foreach (ManagementObject obj in processList) {
                // Retrieve username 
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0) {
                    // return Username
                    response.Username = argList[0];

                    // You can return the domain too like (PCDesktop-123123\Username using instead
                    //response.Username = argList[1] + "\\" + argList[0];
                }

                // Retrieve process description if exists
                if (obj["ExecutablePath"] != null) {
                    try {
                        FileVersionInfo info = FileVersionInfo.GetVersionInfo(obj["ExecutablePath"].ToString());
                        response.Description = info.FileDescription;
                    } catch { }
                }
            }

            return response;
        }

        /// <summary>
        /// Method that converts bytes to its human readable value
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string BytesToReadableValue(long number) {
            List<string> suffixes = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };

            for (int i = 0; i < suffixes.Count; i++) {
                long temp = number / (int)Math.Pow(1024, i + 1);

                if (temp == 0) {
                    return (number / (int)Math.Pow(1024, i)) + suffixes[i];
                }
            }

            return number.ToString();
        }

        /// <summary>
        /// This method renders all the processes of Windows on a ListView with some values and icons.
        /// </summary>
        public void renderProcessesOnListView(Process[] processList, CancellationToken cancellationToken) {
            processDetailListView.Invoke(new Action(() => processDetailListView.Items.Clear()));
            renderBackgroundCounterLabel(processList);
            ImageList Imagelist = new ImageList();

            // Loop through the array of processes to show information of every process in your console
            try {
                foreach (Process process in processList) {
                    cancellationToken.ThrowIfCancellationRequested();

                    // Define the status from a boolean to a simple string
                    string status = (process.Responding == true ? "Responding" : "Not responding");

                    // Retrieve the object of extra information of the process (to retrieve Username and Description)
                    dynamic extraProcessInfo = GetProcessExtraInformation(process.Id);

                    // Create an array of string that will store the information to display in our 
                    string[] row = {
                // 1 Process name
                    process.ProcessName,
                    // 2 Process ID
                    process.Id.ToString(),
                    // 3 Process status
                    status,
                    // 4 Username that started the process
                    extraProcessInfo.Username,
                    // 5 Memory usage
                    BytesToReadableValue(process.PrivateMemorySize64),
                    // 6 Description of the process
                    extraProcessInfo.Description
                };

                    //
                    // As not every process has an icon then, prevent the app from crash
                    try {
                        Imagelist.Images.Add(
                            // Add an unique Key as identifier for the icon (same as the ID of the process)
                            process.Id.ToString(),
                            // Add Icon to the List 
                            Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap()
                        );
                    } catch { }

                    // Create a new Item to add into the list view that expects the row of information as first argument
                    ListViewItem item = new ListViewItem(row) {
                        // Set the ImageIndex of the item as the same defined in the previous try-catch
                        ImageIndex = Imagelist.Images.IndexOfKey(process.Id.ToString())
                    };

                    // Add the Item
                    processDetailListView.Invoke(new Action(() => processDetailListView.Items.Add(item)));
                }
            } catch {
                
            }


            // Set the imagelist of your list view the previous created list :)
            processDetailListView.Invoke(new Action(() => processDetailListView.LargeImageList = Imagelist));
            processDetailListView.Invoke(new Action(() => processDetailListView.SmallImageList = Imagelist));
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

            hideTaskPanel();
            hideSchedulePanel();
        }

        private void enableNavLayer(int pos) {
            switch (pos) {
                case 0:
                    taskNav.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                    taskNav.BorderStyle = BorderStyle.Fixed3D;
                    showTaskPanel();
                    break;
                case 1:
                    scheduleNav.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                    scheduleNav.BorderStyle = BorderStyle.Fixed3D;
                    showSchedulePanel();
                    break;
                case 2:
                    statsNav.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                    statsNav.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
        }

        private void hideTaskPanel() {
            mainTaskPanel.Visible = false;
        }

        private void showTaskPanel() {
            mainTaskPanel.Visible = true;
        }

        private void hideSchedulePanel() {
            schedulePanel.Visible = false;
        }

        private void showSchedulePanel() {
            schedulePanel.Visible = true;
        }


        // ++ nav
        // -- top nav
        private async void foregroundPannel_Click(object sender, EventArgs e) {
            if (leftNavController.changeTopNav(1)) {
                changeTopNav(1);
                leftNavController.getCurrentBackgroundSource().Cancel();
                CancellationTokenSource source = leftNavController.getNewForegroundToken();
                await Task.Run(
                    () => {
                        List<Process> list = getAllOpenProcess(Process.GetProcesses());
                        renderOpenProcessesOnListView(list.ToArray(), source.Token);
                    }
                );
            }
        }

        private async void backgroundPanel_Click(object sender, EventArgs e) {
            if (leftNavController.changeTopNav(2)) {
                changeTopNav(2);
                leftNavController.getCurrentForegroundSource().Cancel();
                CancellationTokenSource source = leftNavController.getNewBackgroundToken();
                try {
                    await Task.Run(
                        () => {
                            List<Process> list = getAllBackgroundProcess(Process.GetProcesses());
                            renderProcessesOnListView(list.ToArray(), source.Token);

                        }
                    );
                } catch {
                    Debug.WriteLine("Cancel background");
                }

            }
        }

        private void changeTopNav(int pos) {
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

        private void addTaskButton_Click(object sender, EventArgs e) {
            AddTaskForm form = new AddTaskForm();
            form.ShowDialog();
            if (form.isSuccess) {
                ScheduleTask task = new ScheduleTask(
                    form.taskNameResult,
                    form.taskDescResult,
                    form.taskFileResult
                    );
                task.setDelayStart(form.delayStart.TotalSeconds);
                task.setInterval(form.timeInterval.TotalSeconds);
                task.setRepeat(form.isRepeat);
                FileUtils.appendToScheduleFile(task.getTaskName(), task);
                MessageBox.Show("Add task succesfully");
                loadScheduleTask();
            }

            DateTime now = DateTime.Now;
            //Process.Start("C:\\Users\\Nhu Hoang\\Desktop\\build.txt");
            DateTime firstRun = new DateTime(now.Year, now.Month, now.Day, now.Hour, 54, 0, 0);
            //Debug.WriteLine();
            
            //c.Wait();
            
            //Debug.WriteLine(FileUtils.getTaskFromFile(FileUtils.getAllScheduleFile()[0]).getDelayStartTotalSeconds().ToString());
        }

        public void loadScheduleTask() {
            string[] taskFiles = FileUtils.getAllScheduleFile();
            scheduleTaskListView.Items.Clear();
            try {
                foreach (string file in taskFiles) {
                    ScheduleTask task = FileUtils.getTaskFromFile(file);
                    //cancellationToken.ThrowIfCancellationRequested();
                    string[] row = {
                    task.getTaskName(),
                    task.getTaskDescription(),
                    task.getTaskFileName(),
                    task.getDelayStartTotalSeconds().ToString(),
                    task.getIntervalTotalSeconds().ToString(),
                    task.getIsRepeat().ToString()
                };
                    ListViewItem item = new ListViewItem(row);

                    // Add the Item
                    scheduleTaskListView.Invoke(new Action(() => scheduleTaskListView.Items.Add(item)));
                }
            } catch {

            }
        }

        private async void mainTaskPanel_VisibleChanged(object sender, EventArgs e) {
            if (((Panel) sender).Visible) {
                if (isCounting) {
                    isCounting = false;
                    Debug.WriteLine("Counting cpu and ram");
                    renderBackgroundCounterLabel(getAllBackgroundProcess(Process.GetProcesses()).ToArray());
                    Task task = Task.Factory.StartNew(() => cThread.counting(counterPanel), TaskCreationOptions.LongRunning);
                    await task;
                }
            }
        }


        private async void applyButton_Click(object sender, EventArgs e) {
            if(FileUtils.getAllScheduleFile().Length > 0) {
                applyButton.Enabled = false;
                addTaskButton.Enabled = false;
                deleteButton.Enabled = false;
                cancelButton.Enabled = true;
                try {
                    await Task.Run(
                        () => {
                            
                            applyTask(leftNavController.getNewScheduleToken().Token, new CountdownEvent(1));
                        }
                    );
                } catch {

                }

                Debug.WriteLine("OKOKOK");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            cancelButton.Enabled = false;
            applyButton.Enabled = true;
            addTaskButton.Enabled = true;
            deleteButton.Enabled = true;
            leftNavController.getCurrentScheduleSource().Cancel();
        }

        private void applyTask(
            CancellationToken cancellationToken,
            CountdownEvent countdownEvent
            ) {
            string[] taskFiles = FileUtils.getAllScheduleFile();
            List<System.Threading.Timer> timers = new List<System.Threading.Timer>();
            CountdownEvent c = new CountdownEvent(1);
            countdownEvent.Reset();
            try {
                foreach (string file in taskFiles) {
                    ScheduleTask task = FileUtils.getTaskFromFile(file);
                    cancellationToken.ThrowIfCancellationRequested();
                    string[] row = {
                    task.getTaskName(),
                    task.getTaskDescription(),
                    task.getTaskFileName(),
                    task.getDelayStartTotalSeconds().ToString(),
                    task.getIntervalTotalSeconds().ToString(),
                    task.getIsRepeat().ToString()
                    };
                    if (task.getIsRepeat()) {
                        System.Threading.Timer timer = new System.Threading.Timer(
                        x => {
                            Process.Start(task.getTaskFileName());
                            //c.Signal(1);
                        },
                        null,
                        task.getDelayStart(),
                        task.getInterval()
                        );
                        timers.Add(timer);
                    } else {
                        System.Threading.Timer timer = new System.Threading.Timer(
                        x => {
                            Process.Start(task.getTaskFileName());
                            //c.Signal(1);
                        },
                        null,
                        (int)task.getDelayStart().TotalMilliseconds,
                        System.Threading.Timeout.Infinite
                        );
                        timers.Add(timer);
                    }
                    
                }
                countdownEvent.Wait(cancellationToken);

            } catch {
                Debug.WriteLine("Cancel schedule");
                foreach(System.Threading.Timer timer in timers) {
                    timer.Dispose();
                }
                timers.Clear();
            }

        }

        private void schedulePanel_VisibleChanged(object sender, EventArgs e) {
            if(((Panel)sender).Visible) {
                loadScheduleTask();
            }
        }

        private void scheduleTaskListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            Debug.WriteLine(e.Item.Index.ToString());
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            try {
                foreach (ListViewItem item in scheduleTaskListView.SelectedItems) {
                    FileUtils.deleteTask(item.Text);
                }
                loadScheduleTask();
            } catch {

            }

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

        public PerformanceCounter getSpecificCpu(string processName) {
            return new PerformanceCounter("Process", "% Processor Time", processName);
        }

        public PerformanceCounter getSpecificRam(string processName) {
            return new PerformanceCounter("Process", "Working Set", processName);
        }


    }

    class LeftNavController {
        private static int navPos = 0;
        private static int topNav = 0;
        private CancellationTokenSource backgroundSource = new CancellationTokenSource();
        private CancellationTokenSource foregroundSource = new CancellationTokenSource();
        private CancellationTokenSource scheduleSource = new CancellationTokenSource();
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

        public CancellationTokenSource getNewBackgroundToken() {
            backgroundSource = new CancellationTokenSource();
            return backgroundSource;
        }

        public CancellationTokenSource getCurrentBackgroundSource() {
            return backgroundSource;
        }

        public CancellationTokenSource getNewForegroundToken() {
            foregroundSource = new CancellationTokenSource();
            return foregroundSource;
        }

        public CancellationTokenSource getCurrentForegroundSource() {
            return foregroundSource;
        }

        public CancellationTokenSource getNewScheduleToken() {
            scheduleSource = new CancellationTokenSource();
            return scheduleSource;
        }

        public CancellationTokenSource getCurrentScheduleSource() {
            return scheduleSource;
        }
        

    }

    class CounterThread {
        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available Bytes");
        private PerformanceCounter specificRamCounter = new PerformanceCounter("Process", "Working Set");
        private ulong totalRamBytes = GetTotalMemoryInBytes();
        public void counting(object obj) {

            try {
                Panel counterPanel = (Panel)obj;
                ProgressBar ramProgress = (ProgressBar) counterPanel.Controls.Find("ramPanel", false)[0].Controls.Find("ramProgress", false)[0];
                ProgressBar cpuProgress = (ProgressBar) counterPanel.Controls.Find("cpuPanel", false)[0].Controls.Find("cpuProgress", false)[0];
                Label ramCounterLabel = (Label)counterPanel.Controls.Find("ramPanel", false)[0].Controls.Find("ramCounterLabel", false)[0];
                Label cpuCounterLabel = (Label)counterPanel.Controls.Find("cpuPanel", false)[0].Controls.Find("cpuCounterLabel", false)[0];
                while (true) {
                    int cpuValue = getCpuCounter();
                    ulong ramValue = getRamCounter();
                    Thread.Sleep(500);
                    cpuValue = getCpuCounter();
                    ramValue = getRamCounter();
                    int ramShow = 100 - (int)((ramValue / (float)totalRamBytes) * 100);
                    Debug.WriteLine(ramValue.ToString());
                    ramProgress.Invoke(new Action(() => ramProgress.Value = ramShow));
                    cpuProgress.Invoke(new Action(() => cpuProgress.Value = cpuValue));
                    ramCounterLabel.Invoke(new Action(() => ramCounterLabel.Text = ramShow + " %"));
                    cpuCounterLabel.Invoke(new Action(() => cpuCounterLabel.Text = cpuValue + " %"));
                    //logPerformance();
                    Thread.Sleep(500);

                }
            } catch(Exception e) {
                Debug.WriteLine(e.StackTrace);
            }


            
        }

        private int getCpuCounter() {
            return (int)cpuCounter.NextValue();
        }

        private ulong getRamCounter() {
            return (ulong)ramCounter.NextValue();
        }

        private void logPerformance() {
            Debug.WriteLine("Cpu: " + cpuCounter.NextValue() + " %");
            Debug.WriteLine("Ram: " + ramCounter.NextValue() + " B");
            Debug.WriteLine("TotalRam: " + totalRamBytes + " B");
        }

        public static ulong GetTotalMemoryInBytes() {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }
    }

    class FileUtils {
        public static CountdownEvent scheduleEvent = new CountdownEvent(1);
        private static string path = Application.StartupPath;
        private static string schedulePath = path + "\\schedule";

        public static void createDirectoryIfNotExist() {
            Directory.CreateDirectory(schedulePath);
        }
        public static bool appendToScheduleFile(string fileName, ScheduleTask task) {
            try {
                createDirectoryIfNotExist();
                string filePath = schedulePath + "\\" + fileName + ".txt";
                string[] lines = { 
                    task.getTaskName(),
                    task.getTaskDescription(),
                    task.getTaskFileName(),
                    task.getDelayStartTotalSeconds().ToString(),
                    task.getIntervalTotalSeconds().ToString(),
                    task.getIsRepeat().ToString()

                };
                File.WriteAllLines(filePath, lines);

            } catch {
                return false;
            }
            return true;
        }

        public static string[] getAllScheduleFile() {
            try {
                return Directory.GetFiles(schedulePath);
            } catch {
                return null;
            }
        }

        public static void deleteTask(string fileName) {
            string filePath = schedulePath + "\\" + fileName + ".txt";
            File.Delete(filePath);
        }

        public static ScheduleTask getTaskFromFile(string fileName) {
            try {
                string[] lines = File.ReadAllLines(fileName);
                ScheduleTask task = new ScheduleTask(lines[0],lines[1], lines[2]);
                task.setDelayStart(double.Parse(lines[3]));
                task.setInterval(double.Parse(lines[4]));
                task.setRepeat(bool.Parse(lines[5]));
                return task;
            } catch {
                return null;
            }

        }

    }

    class ScheduleTask {
        private string taskName = "";
        private string taskDescription = "";
        private string fileName = "";
        private string startFile = "";
        private TimeSpan delayStart = TimeSpan.Zero;
        private TimeSpan interval = TimeSpan.FromMinutes(1);
        private bool isRepeat = true;
        
        public ScheduleTask(string taskName, string taskDescription, string startFile) {
            this.taskName = taskName;
            this.startFile = startFile;
            this.taskDescription = taskDescription;
        }

        public ScheduleTask() {

        }

        public void setDelayStart(double seconds) {
            delayStart = TimeSpan.FromSeconds(seconds);
        }

        public void setInterval(double seconds) {
            interval = TimeSpan.FromSeconds(seconds);
        }

        public void setRepeat(bool isRepeat) {
            this.isRepeat = isRepeat;
        }

        public void setFileName(string fileName) {
            this.fileName = fileName;
        }

        public string getTaskName() {
            return taskName;
        }
        
        public string getTaskDescription() {
            return taskDescription;
        }

        public string getTaskFileName() {
            return startFile;
        }

        public double getDelayStartTotalSeconds() {
            return delayStart.TotalSeconds;
        }

        public double getIntervalTotalSeconds() {
            return interval.TotalSeconds;
        }

        public TimeSpan getDelayStart() {
            return delayStart;
        }

        public TimeSpan getInterval() {
            return interval;
        }

        public bool getIsRepeat() {
            return isRepeat;
        }
    }
}
