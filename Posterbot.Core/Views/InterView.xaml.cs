using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Posterbot.Core.ViewModels;
using Xamarin.Forms;

namespace Posterbot.Core.Views
{
    [MvxContentPagePresentation(WrapInNavigationPage = false, NoHistory = true)]
    public partial class InterView : MvxContentPage<InterViewModel>
    {
        public InterView()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.Android)
            {
                sfbusyindicator.Duration = 1;
                sfbusyindicator.ViewBoxWidth = 100;
                sfbusyindicator.ViewBoxHeight = 100;
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                sfbusyindicator.Duration = 1;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}