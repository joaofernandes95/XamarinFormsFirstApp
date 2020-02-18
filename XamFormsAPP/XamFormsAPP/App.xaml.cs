using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsAPP.Services;
using XamFormsAPP.Views;

namespace XamFormsAPP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new TestPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
