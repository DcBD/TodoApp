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
using DesktopWPFUI.Windows;

namespace DesktopWPFUI.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TasksView.xaml
    /// </summary>
    public partial class TasksView : UserControl
    {
        CreateTaskWindow _createTaskWindow;
        CreateTaskWindow CreateTaskWindow {
            get { return _createTaskWindow; }
            set {
                if (CreateTaskWindow != null) CreateTaskWindow.Close();

                _createTaskWindow = value;

            }
        }
        public TasksView()
        {
            InitializeComponent();
        }

        private void ButtonCreateTask_Click(object sender, RoutedEventArgs e)
        {
            CreateTaskWindow = new CreateTaskWindow((TodoAppMainWindow) Window.GetWindow(this));
            CreateTaskWindow.Show();
        }
    }
}
