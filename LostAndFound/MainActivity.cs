using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace LostAndFound
{
    [Activity(Label = "LostAndFound", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetTheme(Android.Resource.Style.ThemeBlack); // Remove this if you wanna be fired

            SetContentView(Resource.Layout.login);
        }
    }
}

