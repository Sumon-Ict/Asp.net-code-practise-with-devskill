using FirstDemo.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using FirstDemo.Training.BusinessObjects;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Models
{
    public class CourseListModel
    {
        private ICourseService _courseService;
        public IList<Course> Courses { get; set; }


        public CourseListModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }
        public CourseListModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public void LoadModelData()
        {
            Courses = _courseService.GetAllCourse();

        }

        internal object GetCourses(DataTablesAjaxRequestModel tableModel)
        {
            var data = _courseService.GetCourses(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Title", "Fees", "StartDate" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Title,
                                record.Fees.ToString(),
                                record.StartDate.ToString(),
                                record.Id.ToString()
                        }
                    ).ToArray()
            };
        }
    }
}
