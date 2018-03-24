using Android.App;
using Android.Widget;
using Android.OS;

namespace S06_Resources_1_Images
{
    [Activity(Label = "S06_Resources_1_Images", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            ImageView imageView = FindViewById<ImageView>(Resource.Id.imageViewCar);


            button1.Click += delegate
            {
                imageView.SetImageResource(Resource.Drawable.car01);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            };
        }
    }
}

