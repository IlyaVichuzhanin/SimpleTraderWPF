﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
using SimpleTrader.FinancialModelingPrepAPI.Services;
using SimpleTrader.WPF.ViewModels;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.Domain.Services.AuthanticationServices;
using SimpleTrader.Domain.Services.TransactionServices;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;
using SimpleTrader.WPF.State.Navigators;
using SimpleTrader.WPF.ViewModels.Factories;

namespace SimpleTrader.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();
            IBuyStockService buyStockService = serviceProvider.GetRequiredService<IBuyStockService>();
            IAuthanticationService authantication = serviceProvider.GetRequiredService<IAuthanticationService>();
            authantication.Login("SingletonSean", "Test123");
            
            Window window = serviceProvider.GetRequiredService<MainWindow>();
            window.Show();


            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<SimpleTraderDbContextFactory>();
            services.AddSingleton<IDataService<Account>,AccountDataService>();
            services.AddSingleton<IAccountService, AccountDataService>();
            services.AddSingleton<IAuthanticationService, AuthanticationService>();
            services.AddSingleton<IStockPriceService, StockPriceService>();
            services.AddSingleton<IBuyStockService, BuyStockService>();
            services.AddSingleton<IMajorIndexService, MajorIndexService>();

            services.AddSingleton<IPasswordHasher, PasswordHasher>();

            services.AddSingleton<IRootSimpleTraderViewModelFactory, RootSimpleTraderViewModelFactory>();
            

            services.AddSingleton<ISimpleTraderViewModelFactory<HomeViewModel>, HomeViewModelFactory>();
            services.AddSingleton<ISimpleTraderViewModelFactory<PortfolioViewModel>, PortfolioViewModelFactory>();
            services.AddSingleton<ISimpleTraderViewModelFactory<MajorIndexListingViewModel>, MajorIndexListingViewModelFactory>();

            services.AddScoped<INavigator, Navigator>();
            services.AddScoped<MainViewModel>();
            services.AddScoped<BuyViewModel>();
            services.AddScoped<MainWindow>( s=>new MainWindow(s.GetRequiredService<MainViewModel>()));


            return services.BuildServiceProvider();
        }
    }
}
