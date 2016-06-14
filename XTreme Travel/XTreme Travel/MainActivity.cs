using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XTreme_Travel
{

    [Activity(Label = "XTreme_Travel", Theme = "@android:style/Theme.NoTitleBar.Fullscreen", MainLauncher = true, Icon = "@drawable/logo")]
    public class MainActivity : Activity
    {
        private Button mbtSignUp;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mbtSignUp = FindViewById<Button>(Resource.Id.buttonSignUp);

            mbtSignUp.Click += (object sender, EventArgs args) =>
        {
            //Pull up dialog
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            dialog_SignUp signUpDialog = new dialog_SignUp();
            signUpDialog.Show(transaction, "dialog_fragment");
        };  
        }
    }
}

