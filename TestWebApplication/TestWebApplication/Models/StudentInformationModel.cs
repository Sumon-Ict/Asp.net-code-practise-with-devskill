using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApplication.Models
{
    public class StudentInformationModel
    {

        public string StudentName { get; set; }

        public int Id { get; set; }

        public double weight { get; set; }

        public StudentInformationModel()
        {
            StudentName = "Md Sumon Mia";
            Id = 1418013;
            weight = 56.90;

        }

    }
}
