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

namespace DesktopWPFUI.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy CreateTagWindow.xaml
    /// </summary>
    public partial class CreateTagWindow : Window
    {
        
        private CreateTaskWindow CreateTaskWindow { get; set; }

        public CreateTagWindow(CreateTaskWindow createTaskWindow)
        {
            CreateTaskWindow = createTaskWindow;
            
            InitializeComponent();
        }
    }
}
