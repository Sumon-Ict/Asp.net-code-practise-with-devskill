using FirstDemo.Training.BusinessObjects;
using FirstDemo.Training.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Training.Services
{
    public class CourseService : ICourseService
    {

        private readonly TrainingContext _trainingContext;

        public CourseService(TrainingContext trainingContext)
        {
            _trainingContext = trainingContext;

        }

        public IList<Course> GetAllCourse()
        {
            var courseEntities = _trainingContext.Courses.ToList();

            var courses = new List<Course>();

            foreach(var entity  in courseEntities)
            {
                var course = new Course()
                {
                    Title = entity.Title,
                    Fees = entity.Fees

                };
                courses.Add(course);

            }
            return courses;

        }

    }
}
