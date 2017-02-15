using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Steema.TeeChart;
using System.Drawing;
using System.Collections.Generic;

namespace Topfact_f.Droid
{
    [Activity(Label = "Topfact_f", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            Service s = new Service();
            List <Task> l=  s.getTaskArray();
            System.Diagnostics.Debug.WriteLine(l);

            TabLayoutResource = Resource.Layout.main_tagesansicht;

            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            SetContentView(TabLayoutResource);
            
            var tages = new Button(this);
            tages = FindViewById<Button>(Resource.Id.button1);
            tages.Click += delegate {
                StartActivity(typeof(TagesansichtGraph));
            };
            var wochen = new Button(this);
            wochen = FindViewById<Button>(Resource.Id.button2);
            wochen.Click += delegate {
                StartActivity(typeof(Wochenansicht));
            };
            var monats = new Button(this);
            monats = FindViewById<Button>(Resource.Id.button3);
            monats.Click += delegate {
                StartActivity(typeof(Monatsansicht));
            };

        }
    }
}

