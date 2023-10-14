using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManager.Model.Model
{
    public class StudentInfo
    {
      
      public string StudentFirstName { get; set; }

      public string StudentLastName { get; set; }

      public string Gender { get; set; }
    }
}
