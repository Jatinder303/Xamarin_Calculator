using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Xamarin_Calculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView txtNum1;
        private TextView txtNum2;
        private double Num1;
        private double Num2;
        private double Result;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMul;
        private Button btnDivide;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            InitializeControls();
        }

        void InitializeControls()
        {
            btnPlus = FindViewById<Button>(Resource.Id.btnplus);
            btnMinus = FindViewById<Button>(Resource.Id.btnminus);
            btnMul = FindViewById<Button>(Resource.Id.btnmul);
            btnDivide = FindViewById<Button>(Resource.Id.btnDivide);
            txtNum1 = FindViewById<TextView>(Resource.Id.txtNum1);
            txtNum2 = FindViewById<TextView>(Resource.Id.txtNum2);
            btnPlus.Click += onBtnPlus_Click;
            btnMinus.Click += onBtnMinus_Click;
            btnMul.Click += onBtnMul_Click;
            btnDivide.Click += onBtnDivide_Click;
        }

    }
    }
}