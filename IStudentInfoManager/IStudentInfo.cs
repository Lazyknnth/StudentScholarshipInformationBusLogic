using StudentInfoManager.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStudentScholarshipInformation
{
    public interface IStudentInfo
    {
        public void AddStudent(StudentInfo _studentInfo);

        public void UpdateStudent(StudentInfo _studentInfo);
    }

}
