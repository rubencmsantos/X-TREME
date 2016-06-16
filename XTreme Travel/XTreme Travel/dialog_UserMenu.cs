using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace XTreme_Travel
{

[Activity(Label = "UserMenu" )]
    class dialog_UserMenu : DialogFragment
    {
        private Button mbtnLogout;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.dialog_user_menu, container, false);
            return view;

        }
  
      
    }

}

