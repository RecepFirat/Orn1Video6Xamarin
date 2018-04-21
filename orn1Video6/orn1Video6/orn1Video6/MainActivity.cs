using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace orn1Video6
{
    [Activity(Label = "orn1Video6", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public static List<Person> persons =new List<Person>();


        Button btnLogin;
        EditText TxtUserName;
        EditText TxtPassword;
        Button btnInsertPage;
        Button btnGotoListPage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            /*hangı design eklersek o bunu alsın buda onun backendı dıyorum*/
            SetContentView(Resource.Layout.Main);
            TxtUserName = FindViewById<EditText>(Resource.Id.txtUserName);
            TxtPassword = FindViewById<EditText>(Resource.Id.TxtPassworName);
            btnGotoListPage = FindViewById<Button>(Resource.Id.btnListGoser_Main);
            btnInsertPage = FindViewById<Button>(Resource.Id.btn_Goto_Insert_page);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);


            btnGotoListPage.Click += BtnGotoListPage_Click;
            btnInsertPage.Click += BtnInsertPage_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnGotoListPage_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(listActivity));
        }

        private void BtnInsertPage_Click(object sender, System.EventArgs e)
        {

            //verigondermicem direk bas gıtsın typeof deyıp verdigim objenın tıpını alıp startactivitiye gonderıyorum
            StartActivity(typeof(InsertActivity));
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, TxtUserName.Text, ToastLength.Long).Show();//uzun allttan cıkan olayı yapıyorsun burada:)
                                                                            //btnlogine bastıgımda git login aktivity ac dıyorum
                                                                            //StartActivity(typeof(LoginActivity));

            /*diger kısımdakı verileride gonderme ıstıyosanda bunları kullanıyoruz*/
            var intent = new Intent(this, typeof(LoginActivity));
            intent.PutExtra("username", TxtUserName.Text);
            intent.PutExtra("password", TxtPassword.Text);

            /*class gondermek istiyorsanız */
            Person _person = new Person
            {

                Username = TxtUserName.Text,
                Password = TxtPassword.Text

            };
            intent.PutExtra("person",_person.toJson_benim_Yaptigim() /*JsonConvert.SerializeObject (_person)*/);//bunu yapmak icin json Newtonsoft.Json pplugını yuklemen gerekıyo 

            /*daha sonra bunu karsılamam gerekıyo yonlenen sayfasa  tırnak ıcıne yazdıgım keyle bırlıkte*/
            StartActivity(intent);

        }
    }
}

