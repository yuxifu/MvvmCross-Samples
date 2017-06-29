using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using FractalGen.Core.Services.PlatformSpecific;
using FractalGen.Core.ViewModels;
using FractalGen.UI.Droid.UIServices;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;

namespace FractalGen.UI.Droid.Views
{
    [Activity(Label = "My Activity", ScreenOrientation = ScreenOrientation.Landscape)]
    public class GenerateView : MvxActivity
    {
        private GenerateViewModel GenerateViewModel
        {
            get { return (ViewModel as GenerateViewModel); }
        }

        protected override void OnCreate(Bundle bundle)
        {
            HackSetDisplayDimensions();
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.View_Generate);
            // fire off a new fractal request
            GenerateViewModel.RestartCommand.Execute(null);
        }

        private void HackSetDisplayDimensions()
        {
            var disp = (DisplayDimensionsService) Mvx.Resolve<IDisplayDimensionsService>();
            disp.Height = (int) (Resources.DisplayMetrics.HeightPixels*0.8);
            disp.Width = (int) (Resources.DisplayMetrics.WidthPixels*0.8);
        }
    }
}