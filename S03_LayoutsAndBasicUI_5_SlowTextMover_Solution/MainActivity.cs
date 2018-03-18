using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System.Threading;

namespace S03_LayoutsAndBasicUI_5_SlowTextMover_Solution
{
    [Activity(Label = "S03_LayoutsAndBasicUI_5_SlowTextMover_Solution", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            TextView textView = FindViewById<TextView>(Resource.Id.textView1);
            EditText editText = FindViewById<EditText>(Resource.Id.editText1);
            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate
            {
                textView.Text = string.Empty;

                Task.Factory.StartNew(() => {
                    while (editText.Text.Length > 0)
                    {
                        RunOnUiThread(() =>
                        {
                            var letter = editText.Text.Substring(0, 1);
                            textView.Text += letter;
                            editText.Text = editText.Text.Substring(1);

                            // Thread.Sleep an dieser Stelle wird den UI Thread blockieren und die App abstürzen lassen.
                            //Thread.Sleep(1000);

                        });

                        // Thread.Sleep() läuft nun auf einen Extrathread und die UI bleibt daher responsiv.
                        Thread.Sleep(1000);
                    }
                });
            };
        }
    }
}

