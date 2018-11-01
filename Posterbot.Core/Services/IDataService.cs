using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Posterbot.Core.Models;

namespace Posterbot.Core.Services
{
    public interface IDataService
    {
        Task<List<PosterTheme>> GetPosterThemesAsync();
    }
}
