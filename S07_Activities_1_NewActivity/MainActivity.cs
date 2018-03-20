using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace S07_Activities_1_NewActivity
{
    [Activity(Label = "S07_Activities_1_NewActivity", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.buttonNavigateSharing);

            button.Click += delegate
            {
                // Code to open a new activity
                // Bereitet die Verwendung der ShareActivity vor.
                var intent = new Intent(this, typeof(ShareActivity));
                StartActivity(intent);
            };
        }
    }
}