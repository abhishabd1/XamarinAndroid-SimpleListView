using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace simpleListView
{
    [Activity(Label = "simpleListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<string> mItems;
        private ListView mListVew;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            mListVew = FindViewById<ListView>(Resource.Id.ListView1);
            
            mItems = new List<string>();
            mItems.Add("Abhishek");
            mItems.Add("rAVI");
            mItems.Add("sujeeth");
            mItems.Add("rakesh");
            mItems.Add("rakesh");
            mItems.Add("rakesh");
            mItems.Add("rakesh");
            mItems.Add("rakesh");
            mItems.Add("rakesh");

            mItems.Add("rakesh");
            mItems.Add("rakesh");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            mListVew.Adapter = adapter;

            







        }
    }
}

