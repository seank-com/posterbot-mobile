using MvvmCross.ViewModels;
using Posterbot.Core.Models;
using Posterbot.Core.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Posterbot.Core.ViewModels
{
    public class ThemesViewModel : MvxViewModel
    {
        private readonly IDataService _dataService;
        public ThemesViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            _posterThemes = new MvxObservableCollection<PosterTheme>();

            List<PosterTheme> items = await _dataService.GetPosterThemesAsync();
            foreach (PosterTheme theme in items)
            {
                _posterThemes.Add(theme);
            }
        }

        private MvxObservableCollection<PosterTheme> _posterThemes;
        public MvxObservableCollection<PosterTheme> PosterThemes { get => _posterThemes; }
    }
}
