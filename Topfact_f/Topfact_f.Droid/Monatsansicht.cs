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
    [Activity(Label = "Monatsansicht")]
    public class Monatsansicht : Activity
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
            Steema.TeeChart.Styles.Calendar calendar1 = new Steema.TeeChart.Styles.Calendar();
            tChart1.Series.Add(calendar1);
            //calendar1.Add(DateTime.Today, Color.Green);

            Steema.TeeChart.Themes.BlackIsBackTheme theme = new Steema.TeeChart.Themes.BlackIsBackTheme(tChart1.Chart);
            theme.Apply();
            SetContentView(tChart1);
        }
    }
}