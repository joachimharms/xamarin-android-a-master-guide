using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;
using Android.Animation;

namespace S08_GraphicsAndAnimations_4_PropertyAnimations
{
    [Activity(Label = "S08_GraphicsAndAnimations_4_PropertyAnimations", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var buttonAnimation = FindViewById<Button>(Resource.Id.buttonAnimation);
            var imageViewAnimation = FindViewById<ImageView>(Resource.Id.imageView1);

            buttonAnimation.Click += delegate
            {
                var animation = ObjectAnimator.OfFloat(imageViewAnimation, "x", new float[] { imageViewAnimation.GetX(), imageViewAnimation.GetX() + 500 });
                animation.SetDuration(3000);

                animation.RepeatMode = ValueAnimatorRepeatMode.Reverse;
                animation.RepeatCount = 1;

                animation.Start();

            };
        }
    }
}

