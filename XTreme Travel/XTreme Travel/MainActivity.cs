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
        private SGV.SGVFacade sgv;
        private Button mbtSignUp;
        private Button mbtSignIn;
        private EditText mbtnEmail;
        private EditText mbtnPassword;
        public string semail;
        public string spass;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            sgv = new SGV.SGVFacade();

            mbtnEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            mbtnPassword = FindViewById<EditText>(Resource.Id.txtPassword);

            mbtSignIn = FindViewById<Button>(Resource.Id.buttonSignIn);
            mbtSignIn.Click += delegate 
            {

              Boolean testalog = false;
              semail = mbtnEmail.Text;
              spass = mbtnPassword.Text;
              Console.WriteLine(semail);
              Console.WriteLine(spass);


                if (!semail.Equals("") && !spass.Equals(""))
                {
                    testalog = sgv.login(semail, spass);
                }
             
            if(testalog)                    
               StartActivity(typeof(MainMenu));
            };

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

