using Android.App;
using Android.Widget;
using Android.OS;

namespace orn1Video6
{
    [Activity(Label = "orn1Video6", MainLauncher = true)]
    public class MainActivity : Activity
    {

        Button btnLogin;
        EditText TxtUserName;
        EditText TxtPassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            /*hangı design eklersek o bunu alsın buda onun backendı dıyorum*/
            SetContentView(Resource.Layout.Main);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            TxtUserName = FindViewById<EditText>(Resource.Id.txtUserName);
            TxtPassword = FindViewById<EditText>(Resource.Id.TxtPassworName);


            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
           Toast.MakeText(this,TxtUserName.Text,ToastLength.Long).Show()

        }
    }
}

