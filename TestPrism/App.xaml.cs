using System;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using TestPrism.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestPrism
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            //var navParams = new NavigationParameters();
            //navParams.Add()
            await NavigationService.NavigateAsync(
                "MainPage", ("isItBool", "AutoInitialized isItBool"), ("title", "AutoInitialized title"));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SecondPage, SecondPageViewModel>();
            containerRegistry.RegisterForNavigation<ThirdPage, ThirdPageViewModel>();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
