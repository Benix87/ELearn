using ELearn.Core.Interfaces;
using ELearn.DataLayer.Context;
using ELearn.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Core.Services
{
    public class CourseSeasonServices : ICourseSeason
    {
        private readonly ELearnContext _context;
        public CourseSeasonServices(ELearnContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateCourseSeason(CourseSeason courceSeason)
        {
            try
            {
                await _context.CourseSeason.AddAsync(courceSeason);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> DeleteCourseSeason(int id)
        {
            var courseSeason = await GetCourseSeasonById(id);
            if (courseSeason == null)
            {
                throw new Exception("This Course Group Not Found");
            }
            try
            {
                courseSeason.IsDeleted = true;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<CourseSeason> GetCourseSeasonById(int id)
        {
            var courseSeason = await _context.CourseSeason.FindAsync(id);
            if (courseSeason == null)
            {
                throw new Exception("This Course Group Not Found");
            }
            return courseSeason;
        }

        public IEnumerable<CourseSeason> GetCourseSeasons()
        {
            return _context.CourseSeason;
        }

        public async Task<bool> UpdateCourseSeason(CourseSeason courseSeason)
        {
            try
            {
                _context.CourseSeason.Update(courseSeason);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
