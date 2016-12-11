using System;
using Android.OS;
using Android.App;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace LostAndFound
{
    [Activity(Label = "LostAndFound", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetTheme(Android.Resource.Style.ThemeBlack);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login);

            Button butLog_in = FindViewById<Button>(Resource.Id.log_in);
            TextView tvLogin = FindViewById<TextView>(Resource.Id.Login);

            butLog_in.Click += delegate
            {
                SetContentView(Resource.Layout.Main);
                TextView tvNick = FindViewById<TextView>(Resource.Id.textViewNick);
                Button btWyl = FindViewById<Button>(Resource.Id.btWyloguj);
                tvNick.Text += tvLogin.Text;

                btWyl.Click += delegate
                {
                    SetContentView(Resource.Layout.wylogowanie);
                    Button btZP = FindViewById<Button>(Resource.Id.btZalPon);

                    btZP.Click += delegate
                    {
                        SetContentView(Resource.Layout.login);
                    };
                };
            };

        }
    }
}

