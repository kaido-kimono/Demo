using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Demo.Activities
{
    [Activity(Label = "@string/app_name", Theme = "@style/AiTheme", MainLauncher= true)]
    public class Inscription : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.enregistrement);

            // Create your application here
        }
    }
}