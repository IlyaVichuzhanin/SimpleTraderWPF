﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.WPF.ViewModels.Factories
{
    public class HomeViewModelFactory : ISimpleTraderViewModelFactory<HomeViewModel>

    {
        private ISimpleTraderViewModelFactory<MajorIndexListingViewModel> _majorIndexViewModelFactory;

        public HomeViewModelFactory(ISimpleTraderViewModelFactory<MajorIndexListingViewModel> magorIndexViewModelFactory)
        {
            _majorIndexViewModelFactory = magorIndexViewModelFactory;
        }

        public HomeViewModel CreateViewModel()
        {
            return new HomeViewModel(_majorIndexViewModelFactory.CreateViewModel());
        }
    }
}
