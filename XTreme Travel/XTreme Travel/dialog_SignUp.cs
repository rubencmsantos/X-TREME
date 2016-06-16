using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace XTreme_Travel
{

    public class OnSignUpEventArgs : EventArgs
    {
        private string mFirstName;
        private string mLastName;
        private string mNation;
        private string mDate;
        private string mEmail;
        private string mPassword;

        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }
        public string Nation
        {
            get { return mNation; }
            set { mNation = value; }
        }
        public string Date
        {
            get { return mDate; }
            set { mDate = value; }
        }
        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public OnSignUpEventArgs(string firstName, string lastName, string nation, string date, string email, string password) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Nation = nation;
            Date = date;
            Email = email;
            Password = password;
        }
    }
    [Activity(Label = "SIGN-UP", Theme = "@android:style/Theme.NoTitleBar.Fullscreen")]
    class dialog_SignUp : DialogFragment    
    {
        private EditText mtxtFirstName;
        private EditText mtxtLastName;
        private EditText mtxtNation;
        private EditText mtxtDate;
        private EditText mtxtEmail;
        private EditText mtxtPassword;
        private Button mbtnSignUp;

        public object WindowsFeatures { get; private set; }

        public event EventHandler<OnSignUpEventArgs> mOnSignUpComplete;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.dialog_sign_up, container, false);

            mtxtFirstName = view.FindViewById<EditText>(Resource.Id.txtFirstName);
            mtxtLastName = view.FindViewById<EditText>(Resource.Id.txtLastName);
            mtxtNation = view.FindViewById<EditText>(Resource.Id.txtNation);
            mtxtDate = view.FindViewById<EditText>(Resource.Id.txtDate);
            mtxtEmail = view.FindViewById<EditText>(Resource.Id.txtEmail);
            mtxtPassword = view.FindViewById<EditText>(Resource.Id.txtPassword);
            mbtnSignUp = view.FindViewById<Button>(Resource.Id.btnDialogEmail);

            mbtnSignUp.Click += mbtnSignUp_Click; 

            return view;
        }

        private void mbtnSignUp_Click(object sender, EventArgs e)
        {
            // User has clicked SignUp button
            mOnSignUpComplete.Invoke(this, new OnSignUpEventArgs(mtxtFirstName.Text, mtxtLastName.Text, mtxtNation.Text, mtxtDate.Text, mtxtEmail.Text, mtxtPassword.Text));
            this.Dismiss();  
        }

        /*public override void OnActivityCreated(Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);
        }*/
    }
}