using Xamarin.Forms;
using XamFormsAPP.Services;
using XamFormsAPP.Views.GridLayoutExercises;
namespace XamFormsAPP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new ExerciseOnePage();
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
