using IStudentScholarshipInformation;
using StudentInfoManager.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScholarshipInformationBusLogic
{
    public class StudentInfoManager:IStudentInfo
    {
      public void AddStudent(StudentInfo _studentInfo)
        {
            Console.WriteLine("Hello Froshies");
        }
      public void UpdateStudent(StudentInfo _studentInfo)
        {
       
        }
    }
}
