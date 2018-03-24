using Android.App;
using Android.Widget;
using Android.OS;

namespace S06_Resources_4_ScreenDensityAndResolution
{
    [Activity(Label = "S06_Resources_4_ScreenDensityAndResolution", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var imageViewCar = FindViewById<ImageView>(Resource.Id.imageViewCar);
            var buttonShowCar = FindViewById<Button>(Resource.Id.buttonShowCar);

            buttonShowCar.Click += delegate 
            {
                imageViewCar.SetImageResource(Resource.Drawable.ic_car02_french);
            };

            
        }
    }
}

