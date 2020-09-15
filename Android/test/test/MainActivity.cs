using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views.Animations;
using Android.Content;

namespace test
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Android.Support.V7.Widget.Toolbar mToolbar;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);

            button1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(SubActivity));
                StartActivity(intent);
            };
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(SubActivity1));
                StartActivity(intent);
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}