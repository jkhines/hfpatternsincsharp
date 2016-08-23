using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!worker1.IsBusy)
                worker1.RunWorkerAsync();
            if (!worker2.IsBusy)
                worker2.RunWorkerAsync();
        }

        private void worker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            worker1.ReportProgress(0);
        }

        private void worker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.textBox1.Text += String.Format("\r\n{0}\r\n", Singleton.Created);
        }

        private void worker2_DoWork(object sender, DoWorkEventArgs e)
        {
            worker2.ReportProgress(0);
        }

        private void worker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.textBox1.Text += String.Format("\r\n{0}\r\n", Singleton.Created);
        }
    }

    sealed class Singleton
    {
        private Singleton() { }
        public static readonly Singleton Instance = new Singleton();
        public static DateTime Created = System.DateTime.Now;
    }
}
