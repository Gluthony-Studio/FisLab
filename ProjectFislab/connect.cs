using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ProjectFislab
{
    public class connect
    {
        private bool _internet;
        public bool internet
        {
            get { return _internet; }
            set { _internet = value; }
        }
        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KTkJ63vqljTTmt53tb8a4A93lrgN3sAuFG7q5t72",
            BasePath = "https://fislabproject-default-rtdb.firebaseio.com/"
        };
        public IFirebaseClient client;
    }
}