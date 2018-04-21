using Android.App;
using Android.Widget;
using Android.OS;

namespace orn1Video6
{
    [Activity(Label = "orn1Video6", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

