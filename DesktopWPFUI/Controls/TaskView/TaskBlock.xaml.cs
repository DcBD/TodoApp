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
using TaskModel = TodoApp.Domain.Models.Task;
using TodoApp.Domain.Enums;
using DesktopWPFUI.Windows;

namespace DesktopWPFUI.Controls.TaskView
{
    /// <summary>
    /// Logika interakcji dla klasy TaskBlock.xaml
    /// </summary>
    public partial class TaskBlock : UserControl
    {

        TaskContentViewWindow TaskWindow { get; set; }

        public TaskBlock()
        {


            InitializeComponent();


        }



        private void UpdateImageStatusIndicatorIcon()
        {
            if (this.DataContext is TaskModel) {

                TaskModel task = (TaskModel) this.DataContext;

                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(GetIconBasedOnStatus(task.Status), UriKind.Relative);
                bi.EndInit();

                this.ImageStatusIndicator.Source = bi;



            }
        }

        private void UpdateImageStatusIndicatorToolTip()
        {
            if (this.DataContext is TaskModel) {
                TaskModel task = (TaskModel) this.DataContext;
                this.ImageStatusIndicator.ToolTip = GetTooltipBasedOnStatus(task.Status);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            UpdateImageStatusIndicatorIcon();
            UpdateImageStatusIndicatorToolTip();
        }

        private string GetTooltipBasedOnStatus(Status status)
        {
            switch (status) {
                case Status.NEW:
                    return "New";
                case Status.IN_PROGRESS:
                    return "In progress";
                case Status.FINISHED:
                    return "Finished";
                default:
                    return "Not defined";
            }
        }

        private string GetIconBasedOnStatus(Status status)
        {
            switch (status) {
                case Status.IN_PROGRESS:
                    return @"/TodoApp;component/Sources/icons/inprogress.png";
                case Status.FINISHED:
                    return @"/TodoApp;component/Sources/icons/checked.png";
                default:
                    return @"/TodoApp;component/Sources/icons/new.png";
            }



        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is TaskBlock) {
                TaskBlock tb = (TaskBlock) sender;

                if (this.TaskWindow != null) {
                    TaskWindow.Close();
                }

                if (tb.DataContext is TaskModel) {



                    TaskWindow = new TaskContentViewWindow((TaskModel) this.DataContext);
                    TaskWindow.Show();
                }

            }
        }
    }

}