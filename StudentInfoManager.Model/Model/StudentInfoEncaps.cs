using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManager.Model.Model
{
    public class StudentInfoEncaps
    {
        private string _fname;
        private string _lname;
        private string gender;

        public string FirstName
        {
            get
            {
                return _fname;
            }
            set 
            { 
                _fname = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lname;
            }
            set
            {
                _lname = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

    }
}
