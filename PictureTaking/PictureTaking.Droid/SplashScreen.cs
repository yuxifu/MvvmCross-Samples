using Android.App;
using MvvmCross.Droid.Views;

namespace PictureTaking.Droid.Droid
{
    [Activity(Label = "Picture Taken", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}