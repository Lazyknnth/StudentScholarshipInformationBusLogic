using IStudentScholarshipInformation;
using StudentInfoManager.Model.Model;
using StudentScholarshipInformationBusLogic.context;
using StudentScholarshipInformationBusLogic.context.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScholarshipInformationBusLogic
{
    public class StudentInformationManager:IStudentInfo
    {
        public StudentInformationManager() 
        { 

        }
        public void AddStudent(StudentInfo _studentInfo)
        {
            using (var context = new StudentScholarshipInformationDBContext())
            {
                StudentTable _studentTable = new StudentTable();
                
                _studentTable.Student_FirstName = _studentInfo.StudentFirstName;
                _studentTable.Student_LastName = _studentInfo.StudentLastName;
                _studentTable.Gender = _studentInfo.Gender;
               
                context.StudentTable.Add(_studentTable);
                context.SaveChanges();
            }
        }


        public void UpdateStudent(StudentInfo _studentInfo)
        {

        }
    }

}