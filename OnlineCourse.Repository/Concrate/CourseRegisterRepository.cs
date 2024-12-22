using OnlineCourse.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Repository
{
    public class CourseRegisterRepository : BaseRepository<CourseRegister>, ICourseRegisterRepository
    {
        public CourseRegisterRepository(OnlineCourseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
