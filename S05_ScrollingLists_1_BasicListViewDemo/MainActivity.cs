using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace S05_ScrollingLists_1_BasicListViewDemo
{
    [Activity(Label = "S05_ScrollingLists_1_BasicListViewDemo", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            // Erschaffe Daten für unsere ListView
            var data = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                data.Add(string.Format($"Item number: {i.ToString()}"));
            }

            var listView = FindViewById<ListView>(Resource.Id.listView1);
            var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, data);

            listView.Adapter = adapter;
        }
    }
}

