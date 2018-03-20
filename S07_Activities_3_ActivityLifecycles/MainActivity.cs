using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace S07_Activities_3_ActivityLifecycles
{
    [Activity(Label = "S07_Activities_3_ActivityLifecycles", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var buttonNavigateSharing = FindViewById<Button>(Resource.Id.buttonNavigateSharing);

            buttonNavigateSharing.Click += delegate
            {
                var intent = new Intent(this, typeof(Sharing));
                intent.PutExtra("myData", "Hallo Welt");
                StartActivity(intent);
            };
        }
    }
}