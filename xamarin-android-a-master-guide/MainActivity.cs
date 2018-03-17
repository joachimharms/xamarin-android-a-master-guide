using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace xamarin_android_a_master_guide
{
    [Activity(Label = "xamarin_android_a_master_guide", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public bool isBlue = false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate
            {
                if (!isBlue)
                {

                    button.SetBackgroundColor(Color.Blue);
                }
                else
                {

                    button.SetBackgroundColor(Color.Red);
                }
                isBlue = !isBlue;
            };

        }
    }
}

