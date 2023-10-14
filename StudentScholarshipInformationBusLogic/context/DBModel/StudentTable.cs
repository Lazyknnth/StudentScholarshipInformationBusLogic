using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScholarshipInformationBusLogic.context.DBModel
{
    public class StudentTable
    {
        [Key]
        public string Student_FirstName { get; internal set; }
        public string Student_LastName { get; internal set; }
        public string Gender { get; internal set; }
    }
}
