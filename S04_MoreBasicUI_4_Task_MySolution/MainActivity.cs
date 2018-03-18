using Android.App;
using Android.Widget;
using Android.OS;

namespace S04_MoreBasicUI_4_Task_MySolution
{
    [Activity(Label = "S04_MoreBasicUI_4_Task_MySolution", MainLauncher = true)]
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

