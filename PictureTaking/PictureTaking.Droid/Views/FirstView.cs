﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace PictureTaking.Droid.Views
{
    [Activity(Label = "Take a Picture", NoHistory = false, MainLauncher = true)]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override void OnViewModelSet()
        {
            //base.OnViewModelSet();
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
