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

namespace XTreme_Travel
{
    [Activity(Label = "MainMenu", Theme = "@android:style/Theme.NoTitleBar.Fullscreen")]
    public class MainMenu : Activity
    {
        private Button mbuttonUser;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MainMenu);

            mbuttonUser = FindViewById<Button>(Resource.Id.buttonUser);

            mbuttonUser.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_UserMenu usermenuDialog = new dialog_UserMenu();
                usermenuDialog.Show(transaction, "dialog_fragment");
            };
        }
    }
}