using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Posterbot.Core
{
    public partial class FormsApp : Application
    {
        public FormsApp()
        {
            InitializeComponent();
        }
    }
}
