using Android.App;
using Android.Widget;
using Android.OS;
using Android.Transitions;
using Android.Graphics.Drawables;

namespace S08_GraphicsAndAnimations_3_XmlTransitionAnimations
{
    [Activity(Label = "S08_GraphicsAndAnimations_3_XmlTransitionAnimations", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button buttonTransition = FindViewById<Button>(Resource.Id.buttonTransition);

            buttonTransition.Click += delegate
            {
                TransitionDrawable drawable = (TransitionDrawable)FindViewById<ImageView>(Resource.Id.imageViewPCTransition).Drawable;
                drawable.StartTransition(3000);
            };
        }
    }
}

