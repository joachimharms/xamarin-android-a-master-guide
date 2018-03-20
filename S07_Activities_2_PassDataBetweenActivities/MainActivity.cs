using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace S07_Activities_2_PassDataBetweenActivities
{
    [Activity(Label = "S07_Activities_2_PassDataBetweenActivities", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //var buttonNavigateShare = FindViewById<Button>(Resource.Id.buttonNavigateShare);

            //buttonNavigateShare.Click += delegate
            //{
            //    var intent = new Intent(this, typeof(ShareActivity));

            //    StartActivity(intent);
            //};
        }
    }
}