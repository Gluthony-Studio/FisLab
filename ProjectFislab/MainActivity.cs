using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ProjectFislab
{
    [Activity(Label = "Welcome to Fislab", Theme = "@style/Design Light", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            connect data = new connect();

            var message = FindViewById<TextView>(Resource.Id.message);
            var offline = FindViewById<TextView>(Resource.Id.btnOffline);
            try
            {
                data.client = new FireSharp.FirebaseClient(data.config);
                if (data.client != null)
                {
                    message.Text = "You're Connected";
                    data.internet = true;
                }
                var signup = FindViewById<Button>(Resource.Id.btnToSignUp);
                signup.Click += Signup_Click;

                var login = FindViewById<Button>(Resource.Id.btnToLogin);
                login.Click += Login_Click;

                offline.Click += (s, e) =>
                {
                    Intent nextActivity = new Intent(this, typeof(Menu_Activity));
                    StartActivity(nextActivity);
                };
            }
            catch
            {
                message.Text = "You're not connected to Internet";
                data.internet = false;
                offline.Click += (s, e) =>
                {
                    Intent nextActivity = new Intent(this, typeof(Menu_Activity));
                    StartActivity(nextActivity);
                };
            }
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
                    
                }
            };
        }

        private void Signup_Click(object sender, System.EventArgs e)
        {
            SetContentView(Resource.Layout.Lsignup);
            connect data = new connect();
            var inuser = FindViewById<EditText>(Resource.Id.inUsername);
            var inpass = FindViewById<EditText>(Resource.Id.inPass);
            var inemail = FindViewById<EditText>(Resource.Id.inEmail);
            var signup = FindViewById<Button>(Resource.Id.btnSign);

            signup.Click += (s, e) =>
            {
                if (inuser.Text != null && inpass.Text != null && inemail.Text != null)
                {
                    var check = data.client.Get("Account/" + inuser.Text);
                    userAccount Caccount = check.ResultAs<userAccount>();
                    if(Caccount.username != inuser.Text && Caccount.email != inemail.Text)
                    {
                        userAccount account = new userAccount()
                        {
                            username = inuser.Text,
                            email = inemail.Text,
                            password = inpass.Text
                        };
                        var setter = data.client.Set("Account/" + inuser.Text, account);
                        SetContentView(Resource.Layout.Llogin);
                    }
                }
                else
                {

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