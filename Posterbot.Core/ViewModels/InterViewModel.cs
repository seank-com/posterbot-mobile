using MvvmCross.ViewModels;
using Posterbot.Core.Services;

namespace Posterbot.Core.ViewModels
{
    public class InterViewModel : MvxViewModel
    {
        private readonly IDataService _dataService;
        public InterViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _quote = "You miss 100% of the shots you don't take.";
        }

        private string _quote;
        public string Quote
        {
            get => _quote;
            set
            {
                _quote = value;
                RaisePropertyChanged(() => Quote);
            }
        }
    }
}
