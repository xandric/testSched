using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace testSched
{

    
   

    class CollegeClassScheduler
    {
        static void Main(string[] args)
        {
            School testSchool;

            using (SqlConnection conn = new SqlConnection("Integrated Security= SSPI;Initial Catalog=Education"))
            {
                //conn.ConnectionString = "Server = MAXIMUSXI\DEV_001;Database=Education;Trusted_Connection=true";
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from School");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + "  " + reader[1].ToString() + "  " + reader[2].ToString() + "  " + reader[3].ToString());
                    }
                }
              //  while()

            }

            string sDBName = "Education";


            Debug.WriteLine(sDBName);

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


