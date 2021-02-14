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
using System.Windows.Shapes;
using TodoApp.Domain.Services;
using TodoApp.EntityFramework;
using TodoApp.EntityFramework.Services;
using TaskModel = TodoApp.Domain.Models.Task;
namespace DesktopWPFUI.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy CreateTaskWindow.xaml
    /// </summary>
    public partial class CreateTaskWindow : Window
    {
        public CreateTaskWindow()
        {
            InitializeComponent();
        }

        private void BtnSaveHandleClick(object sender, RoutedEventArgs e)
        {
            IDataService<TaskModel> taskService = new TaskDataService(new TodoAppDbContextFactory());


            taskService.Create(new TaskModel {

                Name = this.Name.Text,
                Description = this.Description.Text,
            });

            Console.WriteLine("Saved");
        }
    }
}
