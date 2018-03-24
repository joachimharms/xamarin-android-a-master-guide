using Android.App;
using Android.Widget;
using Android.OS;

namespace S06_Resources_2_Translation
{
    [Activity(Label = "S06_Resources_2_Translation", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var buttonShowImage = FindViewById<Button>(Resource.Id.buttonShowImage);
            var imageViewCar = FindViewById<ImageView>(Resource.Id.imageViewCar);

            buttonShowImage.Click += delegate
            {
                imageViewCar.SetImageResource(Resource.Drawable.car01);
                imageViewCar.SetScaleType(ImageView.ScaleType.CenterCrop);
            };

        }
    }
}

