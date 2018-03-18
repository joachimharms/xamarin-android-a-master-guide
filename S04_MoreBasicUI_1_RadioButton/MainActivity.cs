using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace S04_MoreBasicUI_1_RadioButton
{
    [Activity(Label = "S04_MoreBasicUI_1_RadioButton", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //var radioButton = FindViewById<RadioButton>(Resource.Id.radioButton1);

            //radioButton.Click += delegate
            //{
            //    Log.Debug("DEBUG", "radioButton1 clicked");
            //};

            var radioGroup = FindViewById<RadioGroup>(Resource.Id.radioGroup1);

            radioGroup.CheckedChange += delegate
            {
                var radioButtonText = FindViewById<RadioButton>(radioGroup.CheckedRadioButtonId).Text;
                Log.Debug("DEBUG", string.Format($"Radiobutton Id: {radioGroup.CheckedRadioButtonId}"));
                Log.Debug("DEBUG", string.Format($"Radiobutton Text: {radioButtonText}"));
            };
        }
    }
}

