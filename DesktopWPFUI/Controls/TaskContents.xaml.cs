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
    
        public TaskContents()
        { 


            InitializeComponent();
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
    }
}
