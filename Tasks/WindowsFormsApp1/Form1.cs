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
    public partial class TaskForm : Form {
        public TaskForm() {
            InitializeComponent();
        }

        private void taskNav_Click(object sender, EventArgs e) {
            MessageBox.Show("Hello");
            getAllProcesses();
        }




        // helper
        private void getAllProcesses() {
            Process[] processList = Process.GetProcesses();
            foreach(Process p in processList) {
                Debug.WriteLine(p.ProcessName);
            }
        }


    }
}
