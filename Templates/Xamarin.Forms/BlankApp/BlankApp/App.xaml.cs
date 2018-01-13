﻿using Prism;
using Prism.Ioc;
using BlankApp.ViewModels;
using BlankApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
#if (AutofacContainer)
using Prism.Autofac;
#endif
#if (DryIocContainer)
using Prism.DryIoc;
#endif
#if (UnityContainer)
using Prism.Unity;
#endif

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BlankApp
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }
    }
}
