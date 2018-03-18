using Android.App;
using Android.Widget;
using Android.OS;

namespace S03_LayoutsAndBasicUI_3TextViews
{
    [Activity(Label = "S03_LayoutsAndBasicUI_3TextViews", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button myButton = FindViewById<Button>(Resource.Id.myButton);
            TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);
            EditText editText1 = FindViewById<EditText>(Resource.Id.editText1);

            myButton.Click += delegate
            {
                textView1.Text = editText1.Text;
                editText1.Text = string.Empty;
            };
        }
    }
}

