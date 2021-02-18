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
using TodoApp.Domain.Services;
using TodoApp.EntityFramework;
using TodoApp.EntityFramework.Services;
using TaskModel = TodoApp.Domain.Models.Task;
namespace DesktopWPFUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public TaskModel Task { get; set; }
        public List<TaskModel> Tasks { get; set; }


        public MainWindow()
        {
            TaskDataService taskService = new TaskDataService(new TodoAppDbContextFactory());

            Tasks = taskService.GetAllItems();

            DataContext = this;
            InitializeComponent();
            
        }


    }
}
