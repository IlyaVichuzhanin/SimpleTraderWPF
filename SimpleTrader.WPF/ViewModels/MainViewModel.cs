using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTrader.WPF.State;
using SimpleTrader.WPF.State.Navigators;

namespace SimpleTrader.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; }

        public MainViewModel(INavigator navigator)
        {
            Navigator = navigator;
            Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Home);
        }
    }
}
