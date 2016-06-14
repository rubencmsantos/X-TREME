using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace XTreme_Travel
{
    [Activity(Label = "SIGN-UP", Theme = "@android:style/Theme.NoTitleBar.Fullscreen")]
    class dialog_SignUp : DialogFragment    
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.dialog_sign_up, container, false);
            return view;
        }
    }
}