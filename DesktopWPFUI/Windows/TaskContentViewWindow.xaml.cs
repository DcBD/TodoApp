using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TaskModel = TodoApp.Domain.Models.Task;
namespace DesktopWPFUI.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy TaskContentViewWindow.xaml
    /// </summary>
    public partial class TaskContentViewWindow : Window, INotifyPropertyChanged
    {
        private TaskModel Task { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public TaskContentViewWindow(TaskModel taskModel)
        {
            Task = taskModel;

            this.DataContext = Task;

            InitializeComponent();
        }

        public void Refresh(TaskModel task)
        {
            this.Task = task;
            this.DataContext = Task;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Task"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DataContext"));

        }

    }
}
