using Android.App;
using Android.Widget;
using Android.OS;

namespace S04_MoreBasicsUI_5_Task_OfficialSolution
{
    [Activity(Label = "S04_MoreBasicsUI_5_Task_OfficialSolution", MainLauncher = true)]
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

