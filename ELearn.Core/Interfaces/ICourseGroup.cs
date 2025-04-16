using ELearn.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Core.Interfaces
{
    public interface ICourseGroup
    {
        Task<bool> CreateCourseGroup(CourseGroup courceGroup);
        IEnumerable<CourseGroup> GetCourseGroups();
        Task<CourseGroup> GetCourseGroupById(int id);
        Task<bool> UpdateCourseGroup(CourseGroup courseGroup);
        Task<bool> DeleteCourseGroup(int id);


    }
}
