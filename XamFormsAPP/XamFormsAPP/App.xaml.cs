using Xamarin.Forms;
using XamFormsAPP.Services;
using XamFormsAPP.Views.StackLayoutExercises;

namespace XamFormsAPP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new ExerciseTwoPage();
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
