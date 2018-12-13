using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace testSched
{

    
   

    class CollegeClassScheduler
    {
        static void Main(string[] args)
        {
            School testSchool;

            Debug.WriteLine("test exec");
          
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


