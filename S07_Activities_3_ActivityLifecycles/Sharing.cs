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

namespace S07_Activities_3_ActivityLifecycles
{
    [Activity(Label = "Sharing")]
    public class Sharing : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Sharing);
            var buttonShare = FindViewById<Button>(Resource.Id.buttonShare);

            var myString = Intent.GetStringExtra("myData");

            buttonShare.Click += delegate
            {
                Toast.MakeText(this, myString, ToastLength.Long).Show();
            };
        }
    }
}