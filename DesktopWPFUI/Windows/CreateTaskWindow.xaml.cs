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
using TodoApp.EntityFramework.Services;

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
            IDataService<TodoApp.Domain.Models.Task> taskService = new GenericDataService<TodoApp.Domain.Models.Task>(new TodoApp.EntityFramework.TodoAppDbContextFactory());
            

            taskService.Create(new TodoApp.Domain.Models.Task 
                { 
                    Name = this.Name.Text,
                    Description = this.Description.Text,
                    IsFinished = false,
                    Start = new DateTime(),
                });

            Console.WriteLine("Saved");
        }
    }
}
