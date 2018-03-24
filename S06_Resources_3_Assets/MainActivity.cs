using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.Res;
using System.IO;
using Android.Util;

namespace S06_Resources_3_Assets
{
    [Activity(Label = "S06_Resources_3_Assets", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            string myAssetsContent;
            AssetManager assets = this.Assets;

            using (StreamReader sr = new StreamReader(assets.Open("myAssetText.txt")))
            {
                myAssetsContent = sr.ReadToEnd();
            };

            Log.Debug("DEBUG", myAssetsContent);

        }
    }
}

