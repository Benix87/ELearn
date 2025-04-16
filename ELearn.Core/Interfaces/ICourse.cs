using ELearn.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Core.Interfaces
{
    public interface ICourse
    {
        Task<bool> CreateCourse(Course cource);
        IEnumerable<Course> GetCourses();
        Task<Course> GetCourseById(int id);
        Task<bool> UpdateCourse(Course course);
        Task<bool> DeleteCourse(int id);
    }
}
