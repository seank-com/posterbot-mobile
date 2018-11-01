using MvvmCross;
using MvvmCross.ViewModels;
using Posterbot.Core.Services;
using Posterbot.Core.ViewModels;

namespace Posterbot.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<IDataService, DataService>();

            RegisterAppStart<InterViewModel>();
        }
    }
}