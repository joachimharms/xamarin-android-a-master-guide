﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace S07_Activities_1_NewActivity
{
    [Activity(Label = "ShareActivity")]
    public class ShareActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShareActivityLayout);
        }

        public override void OnBackPressed()
        {
            // base.OnBackPressed();
        }
    }
}