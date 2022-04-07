using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOCSharpStuff
{
    class ExecuteScalerDemo
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2GMLFO\SQLEXPRESS;Initial Catalog=AdoDotNet;Integrated Security=true");
            con.Open();
            
            using (SqlCommand com = new SqlCommand("select * from CtsEmployee", con))
            {
                //Executes the query, and returns the first column of the first row in the 
                //resultset returned by the query. Extra columns or rows are ignored.

                object obj = com.ExecuteScalar();
               
                Console.WriteLine(obj.ToString());

            }

        }
    }
}
