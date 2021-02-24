using DesktopWPFUI.Commands;
using DesktopWPFUI.Models;
using DesktopWPFUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopWPFUI.State.Navigators
{
    public enum ViewType
    {
        Tasks,
        Clients,
        Tags
    }

    public class Navigator : ObservableObject, INavigator, INotifyPropertyChanged
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
