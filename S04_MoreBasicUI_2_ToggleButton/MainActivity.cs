using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace S04_MoreBasicUI_2_ToggleButton
{
    [Activity(Label = "S04_MoreBasicUI_2_ToggleButton", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var toggleButton = FindViewById<ToggleButton>(Resource.Id.toggleButton1);

            toggleButton.CheckedChange += delegate
            {
                Log.Debug("DEBUG", string.Format($"Toggle button checked? {toggleButton.Checked.ToString()}"));
            };
        }
    }
}

