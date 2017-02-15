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

using Steema.TeeChart;
using System.Drawing;

namespace Topfact_f.Droid
{
    [Activity(Label = "Wochenansicht")]
    public class Wochenansicht : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            this.fillGraphs();
        }
        public void fillGraphs()
        {
            Steema.TeeChart.TChart tChart1 = new Steema.TeeChart.TChart(this);
            Steema.TeeChart.Styles.Bar bar1 = new Steema.TeeChart.Styles.Bar();
            tChart1.Series.Add(bar1);
            bar1.Add(68, "Montag", Color.Red);
            bar1.Add(46, "Dienstag", Color.Blue);
            bar1.Add(98, "Mittwoch", Color.Green);
            bar1.Add(66, "Donnerstag", Color.Blue);
            bar1.Add(20, "Freitag", Color.Green);
            bar1.Add(70, "Samstag", Color.Blue);
            bar1.Add(0, "Sonntag", Color.Green);
            Steema.TeeChart.Themes.BlackIsBackTheme theme = new Steema.TeeChart.Themes.BlackIsBackTheme(tChart1.Chart);
            theme.Apply();
            SetContentView(tChart1);
        }
    }

}