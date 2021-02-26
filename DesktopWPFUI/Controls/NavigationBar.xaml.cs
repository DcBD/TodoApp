using DesktopWPFUI.Windows;
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

namespace DesktopWPFUI.Controls
{
    /// <summary>
    /// Logika interakcji dla klasy NavigationBar.xaml
    /// </summary>
    public partial class NavigationBar : UserControl
    {
        private Window CreateTaskWindow { get; set; }

        
        public NavigationBar()
        {
            

            InitializeComponent();
        }

        

        private void CreateTaskButton_Click(object sender, RoutedEventArgs e)
        {

            if (CreateTaskWindow != null) CreateTaskWindow.Close();

            //CreateTaskWindow = new CreateTaskWindow((MainWindow) Window.GetWindow(this));

            CreateTaskWindow.Show();

        }
    }
}
