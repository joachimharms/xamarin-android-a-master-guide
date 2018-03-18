using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace S05_ScrollingLists_3_CustomAdapter
{
    [Activity(Label = "S05_ScrollingLists_3_CustomAdapter", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var listView = FindViewById<ListView>(Resource.Id.listView1);
            List<string> data = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                data.Add(string.Format($"Item number: {i}"));
            }

            ArrayAdapter adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, data);
            listView.Adapter = adapter;

            listView.ItemClick += ListView_ItemClick;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, "Hallo Welt", ToastLength.Long).Show();
        }
    }
}

