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

        public bool Populate_Instructors(ref List<Instructor> isx, int intSchoolID)
        {
            int j = 0;
            int k = 1;

            #region Load Instructors           
            for (int i = 0; i < 8; i++)
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

            #endregion

            return (true);
        }


        public void GO(School s)
        {
            //Console.WriteLine(_strSchoolID + "  " + _strSchoolName + "  " + _strSchoolType + "  " + _webURL);


            int j = 0;


            // Add records for instructors on the given 
            // SchoolID

            List<Instructor> isx = new List<Instructor>();

            Populate_Instructors(ref isx, s.SchoolID);


            string insData = string.Empty;

            for (j = 0; j < isx.Count; j++)
            {
                insData = isx.ElementAt(j).Title + " " + isx.ElementAt(j).FirstName + " " + isx.ElementAt(j).LastName + " " + isx.ElementAt(j).Department + " " + isx.ElementAt(j).DepartmentTitle;
                Console.WriteLine(insData);
            };




        }
    }
    #endregion





}
