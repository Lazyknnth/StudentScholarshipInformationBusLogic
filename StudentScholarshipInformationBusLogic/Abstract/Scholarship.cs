using StudentInfoManager.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScholarshipInformationBusLogic.Abstract
{
    public abstract class Scholarship
    {
        public abstract bool Insert();
        public string ScholarshipSalary(StudentInfo _sTudentInfo)
        {
            return "Your information is checked. ";
        }
    }
}
