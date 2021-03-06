﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace S07_Activities_2_PassData
{
    [Activity(Label = "S07_Activities_2_PassData", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button buttonNavigateToSharing = FindViewById<Button>(Resource.Id.buttonNavigateToShare);

            buttonNavigateToSharing.Click += delegate
            {
                var intent = new Intent(this, typeof(ShareActivity));
                intent.PutExtra("myString", "passed message");
                StartActivity(intent);
            };
        }
    }
}