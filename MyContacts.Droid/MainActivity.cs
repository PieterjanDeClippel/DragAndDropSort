﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MyContacts.Droid
{
	[Activity(Label = "Fenerbahce", Theme = "@android:style/Theme.Material.Light", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //  Properties > Android Options > Advanced: x84 & x86_64

            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

			ActionBar.SetIcon(Android.Resource.Color.Transparent);
        }
    }
}