using StudentScholarshipInformationBusLogic;
using StudentInfoManager.Model.Model;


StudentInformationManager _studentTable = new StudentInformationManager();
StudentInfo _studentInfo = new StudentInfo();

Console.Write("Enter FirstName: ");
string fname = Console.ReadLine();
_studentInfo.StudentFirstName = fname;

Console.Write("Enter LastName: ");
string lname = Console.ReadLine();  
_studentInfo.StudentLastName = lname;

Console.Write("Gender: ");
string gender = Console.ReadLine();
_studentInfo.Gender = gender;


_studentTable.AddStudent(_studentInfo);

