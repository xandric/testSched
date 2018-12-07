using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace testSched
{

    public class School
    {
        private int _intSchoolID;
        private string _strSchoolID;
        private string _strSchoolName;
        private string _strSchoolType;
        private string _webURL;

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

        public School(int iSchoolID, string strSchoolID)
        {
            _intSchoolID = iSchoolID;
            _strSchoolID = strSchoolID;
        }

        public void InitSchool(int iSchoolID, string strSchoolName, string strSchoolType, string webURL)
        {
            _intSchoolID = iSchoolID;
            _strSchoolID = Convert.ToString(_intSchoolID);
            _strSchoolName = strSchoolName;
            _strSchoolType = strSchoolType;
            _webURL = webURL;
        }

        public int ISchoolID { get; set; }

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


        public void GO()
        {
            //Console.WriteLine(s.strSchoolID + "  " + s.strSchoolName + "  " + s.strSchoolType + "  " + s.webURL);

            Console.WriteLine(_strSchoolID + "  " + _strSchoolName + "  " + _strSchoolType + "  " + _webURL);

            // Add Instructors

            /*
                List<int> termsList = new List<int>();
                for (int runs = 0; runs < 400; runs++)
                {
                    termsList.Add(value);
                }

                // You can convert it back to an array if you would like to
                int[] terms = termsList.ToArray();

*/


            List<Instructor> isx = new List<Instructor>();


            for (int i = 0; i < 5; i++)
            {
                isx.Add(new Instructor());                    
            }

            /*  Set all 5 instructors */

            int j = 0;

            j = isx.Count;

            j = 0;
            isx[j].SchoolID = _intSchoolID;
            isx[j].FirstName = "Jake";
            isx[j].LastName = "Towns";
            isx[j].Title = "Dr.";
            isx[j].OfficeHours = "MWF by appointment";
            j++;

            isx[j].SchoolID = _intSchoolID;
            isx[j].FirstName = "Tim";
            isx[j].LastName = "Marks";
            isx[j].Title = "Dr.";
            isx[j].OfficeHours = "TT by appointment";
            j++;


            isx[j].SchoolID = _intSchoolID;
            isx[j].FirstName = "Chi";
            isx[j].LastName = "Wong";
            isx[j].Title = "Dr.";
            isx[j].OfficeHours = "MW 8-11 AM";
            j++;

            isx[j].SchoolID = _intSchoolID;
            isx[j].FirstName = "Eric";
            isx[j].LastName = "Maze";
            isx[j].Title = "Dr.";
            isx[j].OfficeHours = "TT 8-11 AM";
            j++;

            isx[j].SchoolID = _intSchoolID;
            isx[j].FirstName = "Paul";
            isx[j].LastName = "Henderson";
            isx[j].Title = "Dr.";
            isx[j].OfficeHours = "MW 8-11 AM";

            string insData = string.Empty;

            for (j = 0; j < 5; j++)
            {
                insData = isx[j].Title + " " + isx[j].FirstName + " ";
                insData = insData + isx[j].LastName + " ";
                insData = insData + isx[j].OfficeHours;
                Console.WriteLine(insData);
            };


         //   Console.WriteLine("Instructor [0] ID = " + Convert.ToString(isx[1].getCurID()));



        }
    }

    public class Instructor 
    {
        private int _InstructorID;
        private int _SchoolID;
        private string _strFirstName = string.Empty;
        private string _strLastName = string.Empty;
        private string _strTitle = string.Empty;
        private string _strOfficeHours = string.Empty;



        public Instructor()
        {

        }

        public Instructor(List<Instructor> iInstruct, int iPos)
        {
            _InstructorID = iInstruct[iPos].InstructorID;
        }

        public Instructor(int iSchoolID, int InstructorID)
        {
            _InstructorID = InstructorID;
            _SchoolID = iSchoolID;
        }


        /*
        public int getCurID()
        {
            return (_InstructorID);
        }
        public void setCurID(int iInstructorID)
        {
            _InstructorID = iInstructorID;
        }
        */

        public int SchoolID
        {

            get =>  _SchoolID ;

            set => SchoolID = _SchoolID;
        }

        public int InstructorID
        {

            get => _InstructorID;

            set => InstructorID = _InstructorID;
        }


        public string FirstName
        {

            get => _strFirstName;

            set => FirstName = _strFirstName;
        }

        public string LastName
        {

            get => _strLastName;

            set => LastName = _strLastName;
        }
        
        public string Title
        {

            get => _strTitle;

            set => Title = _strTitle;
        }

        public string OfficeHours
        {

            get => _strOfficeHours;

            set => OfficeHours = _strOfficeHours;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            School testSchool;

          //  Console.WriteLine("test exec");

            // School testSchool;

            string conSchoolName = "Chattanooga State";
            string conSchoolType = "2 year";
            string webURL = "www.ChattanoogaState.edu";


            testSchool = new School();
            testSchool.InitSchool(1, conSchoolName, conSchoolType, webURL);

            //Console.WriteLine(testSchool.strSchoolID + "  " + testSchool.strSchoolName + "  " + testSchool.strSchoolType);


            //   conBegin = new Program.conBegin();
            testSchool.GO();

            //GO gO;
            //gO = new GO(testSchool);



        }



    }





   



}


