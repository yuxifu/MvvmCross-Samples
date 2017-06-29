using Android.App;
using MvvmCross.Droid.Views;

namespace InternetMinute.Droid
{
    [Activity(Label = "Internet Time", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}