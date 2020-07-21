using RAT.WPF.Commands;
using RAT.WPF.Models;
using RAT.WPF.State.Navigator;
using RAT.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace RAT.WPF.State.Navigator
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);

        
    }
}
