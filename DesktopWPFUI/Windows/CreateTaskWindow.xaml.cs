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
        private MainWindow MainWindow { get; set; }

        private CreateTagWindow CreateTagWindow {get; set;}

        public CreateTaskWindow(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            InitializeComponent();
        }

        private void BtnSaveHandleClick(object sender, RoutedEventArgs e)
        {
            IDataService<TaskModel> taskService = new TaskDataService(new TodoAppDbContextFactory());


            taskService.Create(new TaskModel {
                Name = this.Name.Text,
                Description = this.Description.Text,
                Start = this.Start.SelectedDate,
            }).Wait();

         

            foreach(TextBox tb in TagsStackPanel.Children.AsParallel()) {
                Console.WriteLine(tb.Text);
            }


            MainWindow.UpdateTasksList();

            this.Close();
            
        }

        private void AddTagButton_Click(object sender, RoutedEventArgs e)
        {
            this.TagsStackPanel.Children.Add(CreateTextBox());
        }

        private TextBox CreateTextBox()
        {
            TextBox tb = new TextBox();
            tb.Margin = new Thickness(5);
            return tb;;
        }
    }
}
