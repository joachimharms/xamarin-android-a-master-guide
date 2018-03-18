using Android.App;
using Android.Widget;
using Android.OS;

namespace S04_MoreBasicsUI_5_Task_OfficialSolution
{
    [Activity(Label = "S04_MoreBasicsUI_5_Task_OfficialSolution", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Spinner spinner;
        RadioGroup radioGroup;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var toggleButton = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
            var linearLayout = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            radioGroup = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            spinner = FindViewById<Spinner>(Resource.Id.spinner1);

            toggleButton.CheckedChange += delegate
            {
                if (toggleButton.Checked)
                {
                    linearLayout.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    linearLayout.Visibility = Android.Views.ViewStates.Gone;
                }
            };

            ChangeList();

            radioGroup.CheckedChange += delegate
            {
                ChangeList();
            };
        }

        protected void ChangeList()
        {
            var checkedId = radioGroup.CheckedRadioButtonId;
            ArrayAdapter adapter;

            if (checkedId == Resource.Id.radioButtonItalian)
            {
                adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.italian, Android.Resource.Layout.SimpleSpinnerItem);
            }
            else
            {
                adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.french, Android.Resource.Layout.SimpleSpinnerItem);
            }

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
        }
    }
}

