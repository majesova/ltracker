using ltracker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ltracker.Data.Repositories
{

    public class CourseRepository : BaseRepository<Course>
    {
        public CourseRepository(LearningContext context) : base(context)
        {

        }
    }


}
