using DesktopWPFUI.State.Navigators;
using DesktopWPFUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopWPFUI.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;
        

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType) parameter;

                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Task:
                        _navigator.CurrentViewModel = new TaskViewModel();
                        break;
                    case ViewType.CreateTask:
                        _navigator.CurrentViewModel = new CreateTaskViewModel();
                        break;
                    case ViewType.Main:
                        _navigator.CurrentViewModel = new MainViewModel();
                        break;
                }
            }
        }
    }
}