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

namespace App1.Droid
{
    [Activity(Label = "Tagesansicht_graph")]
    public class Tagesansicht_graph : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);


            var chart = new TChart(this);
            var pieStyle = new Steema.TeeChart.Styles.Pie();
            chart.Series.Add(pieStyle);

            // Loading data to the Pie series, we can use Random data just to test
            
            var termin1 = 34;
            var termin2 = 44;
            var termin3 = 5;

            var spannungspunkte = termin1 +termin2 + termin3;
            var rest = 100 - spannungspunkte;

            pieStyle.Add(termin1, termin1);
            pieStyle.Add(termin2, termin2);
            pieStyle.Add(termin3, termin3);
            pieStyle.Add(rest, rest);

            //pieStyle.FillSampleValues(4);


            // Setting Pie series as Circular, and marks visible
            pieStyle.Circled = true;
            pieStyle.Marks.Visible = true;

            SetContentView(chart);

            
        }
    }
}