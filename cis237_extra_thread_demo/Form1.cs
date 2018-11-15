using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cis237_extra_thread_demo
{
    public partial class ThreadForm : Form
    {
        public ThreadForm()
        {
            InitializeComponent();
        }

        //************************************
        // Shared Methods
        //************************************
        private void updateProgressBar(int value)
        {
            progressBar.Value = value;
        }


        //************************************
        // Syncronous
        //************************************

        private void syncButton_Click(object sender, EventArgs e)
        {
            PopulateNameLabel();
        }

        private void PopulateNameLabel()
        {
            string name;
            outputLabel.Text = "Fetching Name";
            name = GetName();
            outputLabel.Text = name;
        }

        // This method will simulate our long running task.
        // It uses Thread.Sleep, but you can imagine that instead
        // of sleeping it is doing some networking, or reading from
        // a database.
        private string GetName()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
                updateProgressBar((i * 5) + 5);
            }
            return "David Barnes";
        }

        //************************************
        // Asyncronous
        //************************************

        private async void asyncButton_Click(object sender, EventArgs e)
        {
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += ReportProgress;
            await PopulateNameLabelAsync(progress);
        }

        private void ReportProgress(object sender, int e)
        {
            updateProgressBar(e);
        }

        private async Task PopulateNameLabelAsync(IProgress<int> progress)
        {
            string name;
            outputLabel.Text = "Fetching Name";
            name = await Task.Run(() => GetNameAsync(progress));
            outputLabel.Text = name;
        }

        private string GetNameAsync(IProgress<int> progress)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
                progress.Report((i * 5) + 5);
            }
            return "David Barnes";
        }
    }
}
