using Android.App;
using Android.Widget;
using Android.OS;

namespace xamarin_android_a_master_guide
{
    [Activity(Label = "xamarin_android_a_master_guide", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

