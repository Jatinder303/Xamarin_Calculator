using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Util;

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

        private void onBtnDivide_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 / Num2;
            string result = (Num1 + " / " + Num2 + " = " + Result).ToString();
            string tag = "Divide";
            Log.Info(tag, Num1.ToString());
            Log.Info(tag, Num2.ToString());
            Log.Info(tag, result);
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        private void onBtnMinus_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 - Num2;
            string result = (Num1 + " - " + Num2 + " = " + Result).ToString();
            string tag = "Subtract";
            Log.Info(tag, Num1.ToString());
            Log.Info(tag, Num2.ToString());
            Log.Info(tag, result);
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        private void onBtnMul_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 * Num2;
            string result = (Num1 + " * " + Num2 + " = " + Result).ToString();
            string tag = "Multiply";
            Log.Info(tag, Num1.ToString());
            Log.Info(tag, Num2.ToString());
            Log.Info(tag, result);
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }

        private void onBtnPlus_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Result = Num1 + Num2;
            string result = (Num1 + " + " + Num2 + " = " + Result).ToString();
            string tag = "Addition";
            Log.Info(tag, Num1.ToString());
            Log.Info(tag, Num2.ToString());
            Log.Info(tag, result);
            Toast.MakeText(this, "The Result is " + Result, ToastLength.Long).Show();
        }
    }
}
