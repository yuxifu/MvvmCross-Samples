﻿using Android.App;
using MvvmCross.Droid.Views;

namespace FractalGen.UI.Droid
{
    [Activity(Label = "FractalGen", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.Main)
        {
        }
    }
}