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
using DesktopWPFUI.State.Navigators;
using DesktopWPFUI.ViewModels;
using DesktopWPFUI.Windows;
using TodoApp.Domain.Enums;
using TodoApp.Domain.Models;
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
                GenericDataService<Tag> tagService = new GenericDataService<Tag>(new TodoAppDbContextFactory());
                GenericDataService<TaskTag> taskTagService = new GenericDataService<TaskTag>(new TodoAppDbContextFactory());


                taskService.Delete(taskModel.Id);


                TodoAppMainWindow window = (TodoAppMainWindow) Application.Current.MainWindow;

                if (window.DataContext is TasksViewModel) {
                    TasksViewModel vm = (TasksViewModel) window.DataContext;

                    vm.Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Tasks);

                    Window current = Window.GetWindow(this);

                    current.Close();
                }




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

                

                TodoAppMainWindow window = (TodoAppMainWindow) Application.Current.MainWindow;

                if (window.DataContext is TasksViewModel) {
                    TasksViewModel vm = (TasksViewModel) window.DataContext;

                    vm.Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Tasks);
                }

                Window current = Window.GetWindow(this);

                MessageBox.Show("Status was changed", "Success");
                

                current.Close();
            }
        }




        private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (this.DataContext is TaskModel) {
                var taskModel = (TaskModel) this.DataContext;

                this.StartTaskButton.Visibility = taskModel.Status == Status.NEW ? Visibility.Visible : Visibility.Hidden;
                this.SetTaskAsFinished.Visibility = taskModel.Status == Status.IN_PROGRESS ? Visibility.Visible : Visibility.Hidden;
            }

            

        }
    }
}
