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
    [Activity(Label = "InsertActivity")]
    public class InsertActivity : Activity
    {
        EditText txtUsername;
        EditText TxtPassword;
        Button btnInsert;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.InsertPage);


            txtUsername = FindViewById<EditText>(Resource.Id.txtInsertUserName);
            TxtPassword = FindViewById<EditText>(Resource.Id.txtInsertPassword);
            btnInsert = FindViewById<Button>(Resource.Id.btnInsert);

            btnInsert.Click += BtnInsert_Click;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            MainActivity.persons.Add(new Person
            {

                Username =txtUsername.Text,
               Password=TxtPassword.Text

            });

            Toast.MakeText(this, txtUsername.Text + " eklendi.", ToastLength.Short).Show();/*burada this dememın sebebi burada bu sayfada olsun bu dıyorum*/
        }
    }
}