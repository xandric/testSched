using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSched
{
    public class Instructor
    {
        private int _InstructorID;
        private int _SchoolID;
        private string _FirstName = string.Empty;
        private string _LastName = string.Empty;
        private string _Title = string.Empty;
        private string _Department = string.Empty;
        private string _DepartmentTitle = string.Empty;


        public Instructor()
        {

        }

        public Instructor(int iSchoolID, int InstructorID)
        {
            _InstructorID = InstructorID;
            _SchoolID = iSchoolID;
        }

        
        public int SchoolID
        {
            get; set;
        }

         
        public int InstructorID
        {

            get; set;
        }

        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }


        public string Department
        {
            get; set;
        }

        public string DepartmentTitle
        {
            get; set;
        }

        public bool Populate_Instructors(List<Instructor> isx, int intSchoolID)
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

    }    

}


