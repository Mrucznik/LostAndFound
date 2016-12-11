using System;
using Android.OS;
using Android.App;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            SetContentView(Resource.Layout.Main);

            Button butLog_in = FindViewById<Button>(Resource.Id.log_in);
            Button btZP = FindViewById<Button>(Resource.Id.btZalPon);
            Button btWyl = FindViewById<Button>(Resource.Id.btWyloguj);
            Button butZnalezione = FindViewById<Button>(Resource.Id.butZnal);
            Button butwroc = FindViewById<Button>(Resource.Id.tbWroc);
            Button butwroc2 = FindViewById<Button>(Resource.Id.tibWroc);



            butLog_in.Click += delegate
            {

                SwitchLayout(0);

                TextView tvLogin = FindViewById<TextView>(Resource.Id.Login);
                TextView tvNick = FindViewById<TextView>(Resource.Id.textViewNick);

                tvNick.Text = "Witaj " + tvLogin.Text;

                btWyl.Click += delegate
                {
                    SwitchLayout(1);


                    btZP.Click += delegate
                    {
                        SwitchLayout(2);
                    };
                };

                butZnalezione.Click += delegate
                {
                    SwitchLayout(3);


                    LinearLayout ll = FindViewById<LinearLayout>(Resource.Id.linLay1);

                    for (int i = 0; i < 15; i++)
                    {
                        var LinLayoutA = new LinearLayout(this);
                        var But3 = new Button(this);
                        var TextVie = new TextView(this);
                        TextVie.Text = "Lorem ipsum dolor sit amet, consectetur cras amet.";
                        But3.Text = "Wiecej";
                        ll.AddView(LinLayoutA);
                        LinLayoutA.AddView(But3);
                        LinLayoutA.AddView(TextVie);
                    };

                    butwroc.Click += delegate
                    {
                        SwitchLayout(4);
                    };
                    butwroc2.Click += delegate
                    {
                        SwitchLayout(4);
                    };
                };
            };

           
            
        }
       

        private void SwitchLayout(int SwitchLayoutNum)
        {
            LinearLayout Layout1 = FindViewById<LinearLayout>(Resource.Id.linearLayoutG1);
            LinearLayout Layout2 = FindViewById<LinearLayout>(Resource.Id.linearLayoutG2);
            
            LinearLayout Layout3 = FindViewById<LinearLayout>(Resource.Id.linearLayoutG3);

            LinearLayout Layout4 = FindViewById<LinearLayout>(Resource.Id.linearLayoutG4);

            LinearLayout LayoutTop = FindViewById<LinearLayout>(Resource.Id.linearLayoutTop);

            LinearLayout LayoutWitaj = FindViewById<LinearLayout>(Resource.Id.LinearView);


            if (SwitchLayoutNum == 0)
            {
                Layout1.Visibility = ViewStates.Gone;
                Layout2.Visibility = ViewStates.Visible;
                LayoutWitaj.Visibility = ViewStates.Visible;
            }
            else if(SwitchLayoutNum == 1)
            {
                    Layout2.Visibility = ViewStates.Gone;
                    Layout3.Visibility = ViewStates.Visible;
            }
            else if(SwitchLayoutNum == 2)
            {
                Layout3.Visibility = ViewStates.Gone;
                Layout1.Visibility = ViewStates.Visible;
                LayoutWitaj.Visibility = ViewStates.Gone;
                LayoutTop.Visibility = ViewStates.Gone;
            }
            else if (SwitchLayoutNum == 3)
            {
                Layout2.Visibility = ViewStates.Gone;
                Layout4.Visibility = ViewStates.Visible;

                LayoutWitaj.Visibility = ViewStates.Gone;
                LayoutTop.Visibility = ViewStates.Visible;
            }
            else if(SwitchLayoutNum == 4)
            {
                Layout4.Visibility = ViewStates.Gone;
                Layout2.Visibility = ViewStates.Visible;
                LayoutWitaj.Visibility = ViewStates.Visible;
                LayoutTop.Visibility = ViewStates.Gone;
            }
        }

        



    }
}

