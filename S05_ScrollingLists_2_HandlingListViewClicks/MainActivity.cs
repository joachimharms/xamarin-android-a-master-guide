using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Util;

namespace S05_ScrollingLists_2_HandlingListViewClicks
{
    [Activity(Label = "S05_ScrollingLists_2_HandlingListViewClicks", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            List<string> data = new List<string>();
            var listView = FindViewById<ListView>(Resource.Id.listView1);

            for (int i = 0; i < 100; i++)
            {
                data.Add("Item number: " + i.ToString());
            }

            var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, data);

            listView.Adapter = adapter;

            listView.ItemClick += ListView_ItemClick;


        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Log.Debug("ITEM CLICKED", string.Format($"Number: {e.Position}"));
        }
    }
}

