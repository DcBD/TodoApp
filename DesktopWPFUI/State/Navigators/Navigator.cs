using DesktopWPFUI.Commands;
using DesktopWPFUI.Models;
using DesktopWPFUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopWPFUI.State.Navigators
{
    public enum ViewType
    {
        Home,
        Task,
        CreateTask,
        Main
    }

    public class Navigator : ObservableObject, INavigator
    {

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel { 
            get {
                return _currentViewModel;
            }
            set {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
