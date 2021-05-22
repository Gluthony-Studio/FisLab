using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectFislab
{
    [Activity(Label = "Menu_Activity")]
    public class Menu_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Lmenu);
            connect data = new connect();
            userAccount account = new userAccount();
            date_type Date = new date_type();

            var welcome = FindViewById<TextView>(Resource.Id.txtwelcome);
            var date = FindViewById<TextView>(Resource.Id.txtdate);

            var glb = FindViewById<Button>(Resource.Id.btnglb);

            date.Text = Date.datetext;

            if(data.internet == true)
            {
                welcome.Text = "Welcome " + account.username;
            }
            else
            {
                welcome.Text = "You're in offline mode";
            }
        }
    }
}