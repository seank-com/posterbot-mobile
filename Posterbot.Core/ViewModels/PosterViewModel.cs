using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using Posterbot.Core.Models;
using Posterbot.Core.Services;

namespace Posterbot.Core.ViewModels
{
    public class PosterViewModel : MvxViewModel
    {
        private readonly IDataService _dataService;
        public PosterViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }
    }
}
