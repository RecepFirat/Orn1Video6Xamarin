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
using Newtonsoft.Json;

namespace orn1Video6
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            /*dicem ki kardes senin tasarımın nerde dıye onu gostermem gerekıyo*/
            SetContentView(Resource.Layout.loginPage);
            //string username = Intent.GetStringExtra("username");
            // string password = Intent.GetStringExtra("password");

            /*assete attıınız dosyalarını okuyabılecegınız bı katman*/
           


            /* class gonderme islemi kısmı ***********************/
            var person = Intent.GetStringExtra("person");

            Person selectedPerson = Helper.From_Benim_Yaptigim_Json<Person>(person);/*JsonConvert.DeserializeObject<Person>(person);//serialize edilmis claası tekrar deserialize eddim
           */ 
           Title = selectedPerson.Username;

            TextView tview = FindViewById<TextView>(Resource.Id.lblUserName);/*degiskenler ıd klasında karısık bı sekılde tutuluyo*/

            tview.Text = selectedPerson.Username;
            /*************************/



            //Title = username;





          //  TextView tview = FindViewById<TextView>(Resource.Id.lblUserName);/*degiskenler ıd klasında karısık bı sekılde tutuluyo*/
            //tview.Text = username;
        }
    }
}