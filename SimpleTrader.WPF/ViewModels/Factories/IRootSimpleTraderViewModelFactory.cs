using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTrader.WPF.State.Navigators;

namespace SimpleTrader.WPF.ViewModels.Factories
{
    public interface IRootSimpleTraderViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
