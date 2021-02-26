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
using DesktopWPFUI.Commands;
using DesktopWPFUI.State.Navigators;
using DesktopWPFUI.ViewModels;
using TodoApp.Domain.Models;
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
        private TodoAppMainWindow MainWindow { get; set; }

        private CreateTagWindow CreateTagWindow { get; set; }

        public CreateTaskWindow(TodoAppMainWindow mainWindow)
        {
            MainWindow = mainWindow;
            InitializeComponent();
        }

        private void BtnSaveHandleClick(object sender, RoutedEventArgs e)
        {
            IDataService<TaskModel> taskService = new TaskDataService(new TodoAppDbContextFactory());
            IDataService<Tag> tagService = new GenericDataService<Tag>(new TodoAppDbContextFactory());
            IDataService<TaskTag> taskTagService = new GenericDataService<TaskTag>(new TodoAppDbContextFactory());

            Task<TaskModel> t = taskService.Create(new TaskModel {
                Name = this.Name.Text,
                Description = this.Description.Text,
                Start = this.Start.SelectedDate,
            });

            t.Wait();

            TaskModel taskModel = t.Result;



            foreach (TextBox tb in TagsStackPanel.Children.AsParallel()) {
                if (tb.Text.Length > 0) {
                    Task<Tag> tg = tagService.Create(new Tag {
                        Name = tb.Text
                    });
                    tg.Wait();

                    //Tag tagModel = tg.Result;
                    //Tag tagModel = new Tag {
                    //    Name = tb.Text
                    //};

                    //Task<TaskTag> ttg = taskTagService.Create(new TaskTag {
                    //    Task = taskModel,
                    //    Tag = tagModel
                    //});

                    //ttg.Wait();

                    //TaskTag taskTag = ttg.Result;

                    //if (taskModel.TaskTags == null) {
                    //    taskModel.TaskTags = new List<TaskTag>() { taskTag };
                    //}
                    //else {
                    //    taskModel.TaskTags.Prepend(taskTag);
                    //}


                    //taskService.Update(taskTag.Id, taskModel).Wait();
                }


                //taskModel.TaskTags.Prepend(createdTag)

            }

            if (MainWindow.DataContext is TasksViewModel) {
                TasksViewModel tm = (TasksViewModel) MainWindow.DataContext;

                tm.Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Tasks);


            }


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
            return tb; ;
        }
    }
}
