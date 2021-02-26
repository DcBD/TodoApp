using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopWPFUI.Models;
using DesktopWPFUI.State.Navigators;
using TodoApp.EntityFramework;
using TodoApp.EntityFramework.Services;
using TaskModel = TodoApp.Domain.Models.Task;
namespace DesktopWPFUI.ViewModels
{
    public class TasksViewModel : ViewModelBase
    {


        private List<TaskModel> _tasks = new List<TaskModel>();
        public List<TaskModel> Tasks {
            get { return _tasks; }
            set { _tasks = value; this.OnPropertyChanged("Tasks"); }
        }

        public INavigator Navigator { get; set; } = new Navigator();

        public TasksViewModel()
        {
            UpdateTasksList();
        }


        public void UpdateTasksList()
        {
            TaskDataService taskService = new TaskDataService(new TodoAppDbContextFactory());

            Tasks = taskService.GetAllItems();
    


        }
    }
}
