﻿using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using UsingCompositeCommands.Core;
using UsingCompositeCommands.Views;

namespace UsingCompositeCommands
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleA.ModuleAModule>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }
    }
}
