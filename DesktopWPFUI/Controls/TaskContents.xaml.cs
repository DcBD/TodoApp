using System;
using System.Collections.Generic;
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
using TodoApp.Domain.Enums;
using TodoApp.Domain.Services;
using TodoApp.EntityFramework;
using TodoApp.EntityFramework.Services;
using TaskModel = TodoApp.Domain.Models.Task;
namespace DesktopWPFUI.Controls
{
    /// <summary>
    /// Logika interakcji dla klasy TaskContents.xaml
    /// </summary>
    public partial class TaskContents : UserControl
    {

        public object Task { get; set; }
        public object TaskContentsData { get; set; }

     

        public TaskContents()
        {
            InitializeComponent();



            DataContext = this;
        }

    








        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {

            var taskModel = (TaskModel) this.DataContext;

            if (taskModel != null) {
                IDataService<TaskModel> taskService = new TaskDataService(new TodoAppDbContextFactory());

                taskService.Delete(taskModel.Id);

                MainWindow mainWindow = (MainWindow) Window.GetWindow(this);

                mainWindow.UpdateTasksList();
            }
        }

        private void StartTaskButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeCurrentTaskStatus(Status.IN_PROGRESS);
        }

        private void SetTaskAsFinished_Click(object sender, RoutedEventArgs e)
        {
            ChangeCurrentTaskStatus(Status.FINISHED);
        }

        private void ChangeCurrentTaskStatus(Status status)
        {
            var taskModel = (TaskModel) this.DataContext;

            if (taskModel != null) {
                IDataService<TaskModel> taskService = new TaskDataService(new TodoAppDbContextFactory());

                taskModel.Status = status;

                taskService.Update(taskModel.Id, taskModel);

                MainWindow mainWindow = (MainWindow) Window.GetWindow(this);

                mainWindow.UpdateTasksList();
            }
        }


  

        private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
            if(this.DataContext is TaskModel) {
                var taskModel = (TaskModel) this.DataContext;

                this.StartTaskButton.Visibility = taskModel.Status == Status.NEW ? Visibility.Visible : Visibility.Hidden;
                this.SetTaskAsFinished.Visibility = taskModel.Status == Status.IN_PROGRESS ? Visibility.Visible : Visibility.Hidden;
            }

        }
    }
}
