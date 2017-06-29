using Android.App;
using MvvmCross.Droid.Views;

namespace DailyDilbert.Droid
{
    [Activity(Label = "Daily Dilbert", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}