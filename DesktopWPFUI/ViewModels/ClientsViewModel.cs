using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopWPFUI.State.Navigators;

namespace DesktopWPFUI.ViewModels
{
    public class ClientsViewModel : ViewModelBase
    {
        /// <summary>
        /// Navigator
        /// </summary>
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
