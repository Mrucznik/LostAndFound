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

namespace lostandfoundapp.Classes
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Communicator { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }
}