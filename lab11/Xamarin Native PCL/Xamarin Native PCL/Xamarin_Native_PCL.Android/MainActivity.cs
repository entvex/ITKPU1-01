using System;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin_Forms_PCL;

namespace Xamarin_Native_PCL.Droid
{
	[Activity (Label = "Xamarin_Native_PCL.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
        CprDll cprDll;
        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            
		    cprDll = new CprDll();

		    // Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

            EditText editText = FindViewById<EditText>(Resource.Id.editText1);

		    TextView textView = FindViewById<TextView>(Resource.Id.textView2);


            button.Click += delegate
            {

                CprError cprError;

                cprDll.Check(editText.Text, out cprError);

                if (cprError == CprError.NoError)
                {
                    textView.Text = "Den er gooookent";
                    textView.SetTextColor(Color.Green);
                }
                else
                {
                    textView.Text = "Den er neeej";
                    textView.SetTextColor(Color.Red);
                }
            };
		}
	}
}


