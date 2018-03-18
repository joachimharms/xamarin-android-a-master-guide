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

            var toggleButton = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
            var radioGroup = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            var radioButton1 = FindViewById<RadioButton>(Resource.Id.radioButton1);
            var radioButton2 = FindViewById<RadioButton>(Resource.Id.radioButton2);
            var spinner = FindViewById<Spinner>(Resource.Id.spinner1);

            toggleButton.CheckedChange += delegate
            {
                if (toggleButton.Checked)
                {
                    radioGroup.Visibility = Android.Views.ViewStates.Invisible;
                    spinner.Visibility = Android.Views.ViewStates.Invisible;

                }
                else
                {
                    radioGroup.Visibility = Android.Views.ViewStates.Visible;
                    spinner.Visibility = Android.Views.ViewStates.Visible;
                }
            };
        }
    }
}

