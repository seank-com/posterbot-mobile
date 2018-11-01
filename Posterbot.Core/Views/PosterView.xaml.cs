using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Posterbot.Core.ViewModels;

namespace Posterbot.Core.Views
{
    [MvxContentPagePresentation(WrapInNavigationPage = false, NoHistory = true)]
    public partial class PosterView : MvxContentPage<PosterViewModel>
    {
        public PosterView()
        {
            InitializeComponent();
        }
    }
}
