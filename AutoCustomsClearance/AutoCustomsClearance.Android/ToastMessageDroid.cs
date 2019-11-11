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
using AutoCustomsClearance.Droid;
using AutoCustomsClearance.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(ToastMessageDroid))]
namespace AutoCustomsClearance.Droid
{
    public class ToastMessageDroid : IToastMessage
    {
        public void ShowMesssage(string message)
        {
            Toast toast =  Toast.MakeText(Application.Context, message, ToastLength.Long);
            //toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
        }
    }
}