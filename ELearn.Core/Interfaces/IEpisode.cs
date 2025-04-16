using ELearn.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Core.Interfaces
{
    public interface IEpisode
    {
        Task<bool> CreateEpisode(Episode episode);
        IEnumerable<Episode> GetEpisodes();
        Task<Episode> GetEpisodeById(int id);
        Task<bool> UpdateEpisode(Episode episode);
        Task<bool> DeleteEpisode(int id);
    }
}
}
