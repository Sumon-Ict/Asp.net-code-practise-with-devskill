﻿using FirstDemo.Training.BusinessObjects;
using FirstDemo.Training.Contexts;
using FirstDemo.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Training.Services
{
    public class CourseService : ICourseService
    {

        private readonly ITrainingUnitOfWork _trainingUnitOfWork;

        public CourseService(ITrainingUnitOfWork trainingUnitOfWork)
        {
            _trainingUnitOfWork = trainingUnitOfWork;

        }

        public IList<Course> GetAllCourse()
        {
            var courseEntities = _trainingUnitOfWork.Courses.GetAll();

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
        public void CreateCourse(Course course)
        {
            _trainingUnitOfWork.Courses.Add(
                new Entities.Course
                {
                    Title = course.Title,
                    Fees = course.Fees,
                    StartDate = course.StartDate
                }
                );
            _trainingUnitOfWork.Save();
        }

    }
}
