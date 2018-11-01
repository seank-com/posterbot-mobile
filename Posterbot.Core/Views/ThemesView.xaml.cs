using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Posterbot.Core.ViewModels;

namespace Posterbot.Core.Views
{
    [MvxContentPagePresentation(WrapInNavigationPage = false, NoHistory = true)]
    public partial class ThemesView : MvxContentPage<ThemesViewModel>
    {
        public ThemesView()
        {
            InitializeComponent();
        }
    }
}
