using RAT.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RAT.WPF.State.Navigator
{

    public enum ViewType
    {
        Home,
        Buy,
        Portfolio,
        Login
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get;  }
    }
}
