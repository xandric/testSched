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

        public void InitSchool(int iSchoolID, string strSchoolName, string strSchoolType)
        {
            _intSchoolID = iSchoolID;
            _strSchoolID = Convert.ToString(_intSchoolID);
            _strSchoolName = strSchoolName;
            _strSchoolType = strSchoolType;
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

    }


    class Program
    {

        static void Main(string[] args)
        {
            //testSched.Program.StartSchedule();

            School testSchool;

            Console.WriteLine("test exec");

            // School testSchool;

            string conSchoolName = "Chattanooga State";
            string conSchoolType = "2 year";

            /*
            testSchool = new School();
            testSchool.ISchoolID = 1;
            testSchool.strSchoolID = "1";
            */
            testSchool = new School();
            testSchool.InitSchool(1, conSchoolName, conSchoolType);

            Console.WriteLine(testSchool.strSchoolID + "  " + testSchool.strSchoolName + "  " + testSchool.strSchoolType);
        }

    }





   



}


