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

namespace DesktopWPFUI.Controls
{
    /// <summary>
    /// Logika interakcji dla klasy TaskCard.xaml
    /// </summary>
    public partial class TaskCard : UserControl
    {


        private Brush DefaultBackground { get; set; }

        public TaskCard()
        {
           

            InitializeComponent();

  

            DefaultBackground = this.Card.Background;
        }

        
    }
}
