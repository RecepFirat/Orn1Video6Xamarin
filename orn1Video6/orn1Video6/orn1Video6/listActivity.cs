using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace orn1Video6
{
    [Activity(Label = "listActivity")]
    public class listActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.listpage);
            // Create your application here


            ListView lstPerson = FindViewById<ListView>(Resource.Id.lstPerson);
            ArrayAdapter<Person> adapter = new ArrayAdapter<Person>
                (this, Android.Resource.Layout.SimpleListItem1,Android.Resource.Id.Text1,
                MainActivity.persons);
            lstPerson.Adapter = adapter;

            lstPerson.ItemClick += LstPerson_ItemClick;

            lstPerson.FastScrollEnabled = true;//su yukardan asagı cekme ıslemlerı varya
            lstPerson.FastScrollAlwaysVisible = true;
        }

        private void LstPerson_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var id = e.Id;

            var parent = e.Parent;
            var _Position = e.Position;//index no
            var view = e.View;

            var selectedPerson = MainActivity.persons[_Position];
            Toast.MakeText(this, selectedPerson.Username, ToastLength.Long).Show();

        }
    }
}