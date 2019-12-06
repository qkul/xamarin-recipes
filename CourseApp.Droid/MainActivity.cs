using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using CourseApp.Core;

namespace CourseApp.Droid
{
	[Activity(Label = "This is working?")]
	public class MainActivity : MvxAppCompatActivity<HomePageViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_main);
		}
	}
}