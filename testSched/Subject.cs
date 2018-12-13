using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSched
{


    class Subject
    {
        private int _SubjectID = -1;
        private int _SchoolID = -1;
        private string _SubjectName = string.Empty;
        private string _SubjectCode = string.Empty;

        public int SchoolID
        {
            get; set;
        }

        public int SubjectID
        {
            get; set;
        }

        public string SubjectName
        {
            get; set;
        }

        public string SubjectCode
        {
            get; set;
        }



        public Subject(int iSchoolID, int iSubjectID)
        {
            _SchoolID = iSchoolID;
            _SubjectID = iSubjectID;

        }


            
    }




}
