﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace S07_Activities_2_PassData
{
    [Activity(Label = "ShareActivity")]
    public class ShareActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Share);
            var myString = Intent.GetStringExtra("myString");

            Button shareButton = FindViewById<Button>(Resource.Id.buttonShare);

            shareButton.Click += delegate
            {
                Log.Debug("DEBUG", "Message: " + myString);
            };
        }
    }
}