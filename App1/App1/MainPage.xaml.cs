
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{

    public partial class Mainpage : ContentPage
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Android.Widget.Button)sender).Text = $"You clicked {count} times.";
        }
    }
}

