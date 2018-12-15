using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSched
{
    public class School
    {
        private int _intSchoolID;
        private string _strSchoolID;
        private string _strSchoolName;
        private string _strSchoolType;
        private string _webURL;
        private int _SchoolID = 0;


        #region School Properties
        public int SchoolID { get; set; }

        public string strSchoolID
        {

            get => _strSchoolID;

            set => strSchoolID = _strSchoolID;
        }


        public string strSchoolName
        {

            get => _strSchoolName;

            set => strSchoolName = _strSchoolName;
        }


        public string strSchoolType
        {

            get => _strSchoolType;

            set => strSchoolType = _strSchoolType;
        }

        public string webURL
        {

            get => _webURL;

            set => webURL = _webURL;
        }
        #endregion

        #region School Constructors
        public School()
        {
        }
        public School(int iSchoolID)
        {
            _intSchoolID = iSchoolID;

        }
        public School(string strSchoolID)
        {
            _strSchoolID = strSchoolID;
        }

        public School(int iSchoolIDtestSched, string strSchoolID)
        {
            _intSchoolID = iSchoolIDtestSched;
            _strSchoolID = strSchoolID;
            _SchoolID = _intSchoolID;
        }
        #endregion

        #region School Methods
        public void InitSchool(int iSchoolID, string strSchoolName, string strSchoolType, string webURL)
        {
            _intSchoolID = iSchoolID;
            SchoolID = iSchoolID;
            _strSchoolID = Convert.ToString(_intSchoolID);
            _strSchoolName = strSchoolName;
            _strSchoolType = strSchoolType;
            _webURL = webURL;
        }


        internal bool Populate_Subjects(ref List<Subject> sub, int intSchoolID)
        {
            const int conSubjectCount= 5;
            int j = 0;
            int k = 1;
            #region Load Subjects           
            for (int i = 0; i < conSubjectCount; i++)
            {
                sub.Add(new Subject(intSchoolID, i));
            }

            sub.ElementAt(j).SchoolID = intSchoolID;
            sub.ElementAt(j).SubjectID = k;
            sub.ElementAt(j).SubjectName = "Math";
            sub.ElementAt(j).SubjectCode = "Math 1720";
            j++;
            k++;

            sub.ElementAt(j).SchoolID = intSchoolID;
            sub.ElementAt(j).SubjectID = k;
            sub.ElementAt(j).SubjectName = "ENGR";
            sub.ElementAt(j).SubjectCode = "ENGR 1850";
            j++;
            k++;

            sub.ElementAt(j).SchoolID = intSchoolID;
            sub.ElementAt(j).SubjectID = k;
            sub.ElementAt(j).SubjectName = "ENGR";
            sub.ElementAt(j).SubjectCode = "ENGR 1011";
            j++;
            k++;

            sub.ElementAt(j).SchoolID = intSchoolID;
            sub.ElementAt(j).SubjectID = k;
            sub.ElementAt(j).SubjectName = "ART";
            sub.ElementAt(j).SubjectCode = "ART 1030";
            j++;
            k++;

            sub.ElementAt(j).SchoolID = intSchoolID;
            sub.ElementAt(j).SubjectID = k;
            sub.ElementAt(j).SubjectName = "ECON";
            sub.ElementAt(j).SubjectCode = "ECON 2100";
            j++;
            k++;

            #endregion
            return (true);
        }



        public bool Populate_Instructors(ref List<Instructor> isx, int intSchoolID)
        {
            int j = 0;
            int k = 1;
            const int conInstructorCount = 11;

            #region Load Instructors           
            for (int i = 0; i < conInstructorCount; i++)
            {
                isx.Add(new Instructor(intSchoolID, i));
            }


            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "To Be Determined";
            isx.ElementAt(j).LastName = "";
            isx.ElementAt(j).Title = "";
            isx.ElementAt(j).Department = "";
            isx.ElementAt(j).DepartmentTitle = "";
            j++;
            k++;


            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Natilie";
            isx.ElementAt(j).LastName = "Pitts";
            isx.ElementAt(j).Title = "Associate Professor, Humanities";
            isx.ElementAt(j).Department = "Humanities";
            isx.ElementAt(j).DepartmentTitle = "Humanities & Fine Arts (4440)";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Ann";
            isx.ElementAt(j).LastName = "Nicodemi";
            isx.ElementAt(j).Title = "Associate Professor, Humanities";
            isx.ElementAt(j).Department = "Humanities";
            isx.ElementAt(j).DepartmentTitle = "Humanities & Fine Arts (4440)";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Brian";
            isx.ElementAt(j).LastName = "Hale";
            isx.ElementAt(j).Title = "Professor, English";
            isx.ElementAt(j).Department = "Humanities";
            isx.ElementAt(j).DepartmentTitle = "Humanities & Fine Arts (4440)";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Joshua";
            isx.ElementAt(j).LastName = "Johnson";
            isx.ElementAt(j).Title = "Instructor, English";
            isx.ElementAt(j).Department = "Humanities";
            isx.ElementAt(j).DepartmentTitle = "Humanities & Fine Arts (4440)";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Adrienne";
            isx.ElementAt(j).LastName = "Kaufmann";
            isx.ElementAt(j).Title = "Instructor, English";
            isx.ElementAt(j).Department = "Humanities";
            isx.ElementAt(j).DepartmentTitle = "Humanities & Fine Arts (4440)";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Joshua";
            isx.ElementAt(j).LastName = "Johnson";
            isx.ElementAt(j).Title = "Instructor, English";
            isx.ElementAt(j).Department = "Humanities";
            isx.ElementAt(j).DepartmentTitle = "Humanities & Fine Arts (4440)";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "J.";
            isx.ElementAt(j).LastName = "Ledford";
            isx.ElementAt(j).Title = "Associate Professor, Humanities";
            isx.ElementAt(j).Department = "Art";
            isx.ElementAt(j).DepartmentTitle = "Humanities & Fine Arts (4440)";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Unknown #1";
            isx.ElementAt(j).LastName = "ENGR Prof 1011";
            isx.ElementAt(j).Title = "Associate Professor, Engineering";
            isx.ElementAt(j).Department = "Engineering";
            isx.ElementAt(j).DepartmentTitle = "Engineering (1011)";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Unknown #2";
            isx.ElementAt(j).LastName = "ENGR Prof 1850";
            isx.ElementAt(j).Title = "Associate Professor, Engineering";
            isx.ElementAt(j).Department = "Engineering";
            isx.ElementAt(j).DepartmentTitle = "Engineering (1850)";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Mr.";
            isx.ElementAt(j).LastName = "Adcock";
            isx.ElementAt(j).Title = "Associate Professor, Economics";
            isx.ElementAt(j).Department = "ECON";
            isx.ElementAt(j).DepartmentTitle = "ECON (2100)" ;
            j++;
            k++;
            #endregion

            return (true);
        }


        public void GO(School s)
        {
            //Console.WriteLine(_strSchoolID + "  " + _strSchoolName + "  " + _strSchoolType + "  " + _webURL);


           // Add records for instructors on the given 
            // SchoolID

            List<Instructor> isx = new List<Instructor>();

            Populate_Instructors(ref isx, s.SchoolID);

            string insData = string.Empty;

            for (int j = 0; j < isx.Count; j++)
            {
                insData = isx.ElementAt(j).Title + " " + isx.ElementAt(j).FirstName + " " + isx.ElementAt(j).LastName + " " + isx.ElementAt(j).Department + " " + isx.ElementAt(j).DepartmentTitle;
                Console.WriteLine(insData);
            };



            // Add records for subjects on the given 
            // SchoolID to schedule

            List<Subject> subj = new List<Subject>();

            Populate_Subjects(ref subj, s.SchoolID);

            string subData = string.Empty;

            for (int k = 0; k < subj.Count; k++)
            {
                subData = "SubjectID #" + subj.ElementAt(k).SubjectID.ToString();
                subData = subData + " SchoolID =" + subj.ElementAt(k).SchoolID.ToString();
                subData = subData + "   Subject =  " + subj.ElementAt(k).SubjectName.ToString();
                subData = subData + "   Subject Code = " + subj.ElementAt(k).SubjectCode.ToString();
                Console.WriteLine(subData);
            };

        }
    }
    #endregion





}
