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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesktopWPFUI.Controls;
using TodoApp.Domain.Services;
using TodoApp.EntityFramework;
using TodoApp.EntityFramework.Services;
using TaskModel = TodoApp.Domain.Models.Task;
namespace DesktopWPFUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private TaskModel _currentTask;

        public event PropertyChangedEventHandler PropertyChanged;

        public TaskModel CurrentTask {
            get { return _currentTask; }
            set { _currentTask = value; this.RaisePropertyChanged("CurrentTask"); }
        }

        private List<TaskModel> _tasks;
        public List<TaskModel> Tasks {
            get { return _tasks; }
            set { _tasks = value; this.RaisePropertyChanged("Tasks"); }
        }


        public MainWindow()
        {

            UpdateTasksList();

            DataContext = this;

            InitializeComponent();

        }

        public void UpdateTasksList()
        {
            TaskDataService taskService = new TaskDataService(new TodoAppDbContextFactory());

            Tasks = taskService.GetAllItems();

            
            if(Tasks.Count > 0) {
                CurrentTask = Tasks?.Last();

            }

        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void TasksItemList_MouseDown(object sender, MouseButtonEventArgs e)
        {

            InitializeComponent();
        }

        private void TaskCard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var taskCard = (TaskCard) sender;
            var taskModel = (TaskModel) taskCard.DataContext;

            if(taskModel != null) {
                CurrentTask = taskModel;
            }
           
        }
    }
}
