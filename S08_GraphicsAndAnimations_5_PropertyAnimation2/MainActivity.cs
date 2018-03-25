using Android.App;
using Android.Widget;
using Android.OS;
using Android.Animation;
using Android.Util;

namespace S08_GraphicsAndAnimations_5_PropertyAnimation2
{
    [Activity(Label = "S08_GraphicsAndAnimations_5_PropertyAnimation2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var buttonStartAnimation = FindViewById<Button>(Resource.Id.buttonAnimation);
            var imageViewAnimation = FindViewById<ImageView>(Resource.Id.imageViewAnimation);

            buttonStartAnimation.Click += delegate
            {
                var animation = ObjectAnimator.OfFloat(imageViewAnimation, "alpha", new float[] { imageViewAnimation.Alpha, 0.0f });
                animation.SetDuration(3000);

                animation.RepeatMode = ValueAnimatorRepeatMode.Reverse;
                animation.RepeatCount = 10;

                animation.Start();

                Log.Debug("DEBUG", "Bin schon da. Bevor die Animation 10 mal ausgeführt wird.");

            };

        }
    }
}

