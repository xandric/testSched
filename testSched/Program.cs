using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
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
        private int iSchoolID = 0;
        

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
            iSchoolID = _intSchoolID;
        }

        public void InitSchool(int iSchoolID, string strSchoolName, string strSchoolType, string webURL)
        {
            _intSchoolID = iSchoolID;
            SchoolID = iSchoolID;
            _strSchoolID = Convert.ToString(_intSchoolID);
            _strSchoolName = strSchoolName;
            _strSchoolType = strSchoolType;
            _webURL = webURL;
        }

        
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


        public void GO(School s)
        {
            //Console.WriteLine(s.strSchoolID + "  " + s.strSchoolName + "  " + s.strSchoolType + "  " + s.webURL);

            Console.WriteLine(_strSchoolID + "  " + _strSchoolName + "  " + _strSchoolType + "  " + _webURL);

            
            int iGOSchoolID = 0;

            iGOSchoolID = 1;
            iGOSchoolID = s.SchoolID;

            List<Instructor> isx = new List<Instructor>();

            for (int i = 1; i < 6; i++)
            {
                isx.Add(new Instructor(iGOSchoolID, i));                    
            }

            /*  Set all 5 instructors */
           
            int j = 0;
            int k = 1;
            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Jake"; 
            isx.ElementAt(j).LastName = "Towns";
            isx.ElementAt(j).Title = "Dr.";
            isx.ElementAt(j).OfficeHours = "MWF by appointment";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Tim";
            isx.ElementAt(j).LastName = "Marks";
            isx.ElementAt(j).Title = "Dr.";
            isx.ElementAt(j).OfficeHours = "TT by appointment";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Chi";
            isx.ElementAt(j).LastName = "Wong";
            isx.ElementAt(j).Title = "Dr.";
            isx.ElementAt(j).OfficeHours = "MW 8-11 AM";
            j++;
            k++;

            isx.ElementAt(j).InstructorID =k;
            isx.ElementAt(j).FirstName = "Eric";
            isx.ElementAt(j).LastName = "Maze";
            isx.ElementAt(j).Title = "Dr.";
            isx.ElementAt(j).OfficeHours = "TT 8-11 AM";
            j++;
            k++;

            isx.ElementAt(j).InstructorID = k;
            isx.ElementAt(j).FirstName = "Paul";
            isx.ElementAt(j).LastName = "Henderson";
            isx.ElementAt(j).Title = "Dr.";
            isx.ElementAt(j).OfficeHours = "WF 8-11 AM";





            string insData = string.Empty;

            for (j = 0; j < isx.Count; j++)
            {
                insData = isx.ElementAt(j).Title + " " + isx.ElementAt(j).FirstName + " " + isx.ElementAt(j).LastName + " " + isx.ElementAt(j).OfficeHours;
                Console.WriteLine(insData);
            };




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
            _InstructorID = iInstruct.ElementAt(iPos).InstructorID;
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

        public string OfficeHours
        {
            get; set;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            School testSchool;

            Debug.WriteLine("test exec");
          //  Console.WriteLine("test exec");

            string conSchoolName = "Chattanooga State";
            string conSchoolType = "2 year";
            string webURL = "www.ChattanoogaState.edu";


            testSchool = new School();
            testSchool.InitSchool(1, conSchoolName, conSchoolType, webURL);

            Debug.WriteLine(testSchool.strSchoolID + "  " + testSchool.strSchoolName + "  " + testSchool.strSchoolType);

            testSchool.GO(testSchool);





        }



    }





   



}


