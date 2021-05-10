using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ProjectFislab
{
    [Activity(Label = "Welcome to Fislab", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KTkJ63vqljTTmt53tb8a4A93lrgN3sAuFG7q5t72",
            BasePath = "https://fislabproject-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                var message = FindViewById<TextView>(Resource.Id.message);
                message.Text = "You're Connected";
            }
            var signup = FindViewById<Button>(Resource.Id.btnToSignUp);
            signup.Click += Signup_Click;

            var login = FindViewById<Button>(Resource.Id.btnToLogin);
            login.Click += Login_Click;
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            SetContentView(Resource.Layout.Llogin);
            var user = FindViewById<EditText>(Resource.Id.tbUsername);
            var pass = FindViewById<EditText>(Resource.Id.tbPassword);
            var login = FindViewById<Button>(Resource.Id.btnLogin);

            login.Click += (s, e) =>
            {
                if (user.Text != null && pass.Text != null)
                {
                    userAccount account = new userAccount(user.Text, pass.Text);
                    account.login();
                }
            };
        }

        private void Signup_Click(object sender, System.EventArgs e)
        {
            SetContentView(Resource.Layout.Lsignup);
            var inuser = FindViewById<EditText>(Resource.Id.inUsername);
            var inpass = FindViewById<EditText>(Resource.Id.inPass);
            var inemail = FindViewById<EditText>(Resource.Id.inEmail);
            var signup = FindViewById<Button>(Resource.Id.btnSign);

            signup.Click += (s, e) =>
            {
                if (inuser.Text != null && inpass.Text != null && inemail.Text != null)
                {
                    userAccount account = new userAccount(inuser.Text, inpass.Text, inemail.Text);
                    account.signup();
                }
            };
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}