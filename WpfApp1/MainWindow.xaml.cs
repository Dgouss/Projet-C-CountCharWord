using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using métier;
using System.Threading;
using System.Windows.Threading;
using System.Diagnostics;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Iview
    {
        Controller c = new Controller();

        BackgroundWorker worker = new BackgroundWorker();
        public MainWindow()
        {
            c.view = this;
            InitializeComponent();
            Save.Visibility = Visibility.Hidden;
            Save_entry.Visibility = Visibility.Hidden;

            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;

            worker.ProgressChanged += worker_ProgressChanged;
            worker.DoWork += workerWord_DoWork;
        }

        private void workerWord_DoWork(object sender, DoWorkEventArgs e)
        {
            bool IsChecked = false;
            System.Windows.Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, (ThreadStart)delegate { c.source = Source.Text; });
            System.Windows.Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, (ThreadStart)delegate { c.Label = Save_entry.Text; });
            Dispatcher.Invoke(DispatcherPriority.Normal, (ThreadStart)delegate { IsChecked = (bool)Yes.IsChecked; });
            c.CountWord(IsChecked);
            c.CountChar(IsChecked);

            System.Windows.Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, (ThreadStart)delegate { resultWatch.Text = c.varResult; });
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
            pourcent.Content = e.ProgressPercentage + "%";
        }

        public void reporter(int i, int[] c)
        {
            worker.ReportProgress((i * 100 / c.Length + 1));
        }


        private void Lancer_Programme(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void Yes_Checked(object sender, RoutedEventArgs e)
        {
            No.IsChecked = false;
            if (Yes.IsChecked == true)
            {
                Save.Visibility = Visibility.Visible;
                Save_entry.Visibility = Visibility.Visible;
            }
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            Yes.IsChecked = false;
            if (No.IsChecked == true)
            {
                Save.Visibility = Visibility.Hidden;
                Save_entry.Visibility = Visibility.Hidden;
            }
        }
        private void Source_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Save_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}