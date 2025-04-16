using ELearn.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Core.Interfaces
{
    public interface ICourseSeason
    {
        Task<bool> CreateCourseSeason(CourseSeason courceSeason);
        IEnumerable<CourseSeason> GetCourseSeasons();
        Task<CourseSeason> GetCourseSeasonById(int id);
        Task<bool> UpdateCourseSeason(CourseSeason courseSeason);
        Task<bool> DeleteCourseSeason(int id);

    }
}

