using Android.App;
using Android.Widget;
using Android.OS;

namespace S04_MoreBasicUI_3_Spinners
{
    [Activity(Label = "S04_MoreBasicUI_3_Spinners", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var spinner = FindViewById<Spinner>(Resource.Id.spinner1);
            ArrayAdapter adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

            spinner.Adapter = adapter;

            spinner.ItemSelected += delegate
            {
                // Business Logik hier
            };

        }
    }
}

