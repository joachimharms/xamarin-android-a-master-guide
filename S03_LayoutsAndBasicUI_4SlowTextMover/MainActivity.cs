using Android.App;
using Android.Widget;
using Android.OS;

namespace S03_LayoutsAndBasicUI_4SlowTextMover
{
    [Activity(Label = "S03_LayoutsAndBasicUI_4SlowTextMover", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);
            EditText editText1 = FindViewById<EditText>(Resource.Id.editText1);
            Button button1 = FindViewById<Button>(Resource.Id.button1);

            button1.Click += delegate
            {
                if (editText1.Text.Length > 0)
                {
                    string userInput = editText1.Text.ToString();
                    textView1.Text += userInput[0];
                    editText1.Text = userInput.Remove(0, 1);
                }
            };

        }
    }
}

