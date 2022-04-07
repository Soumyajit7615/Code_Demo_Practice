using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; // API

namespace ADOCSharpStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2GMLFO\SQLEXPRESS;Initial Catalog=AdoDotNet;Integrated Security=true");
            con.Open();
            SqlCommand com = new SqlCommand("select * from CtsEmployee", con);
            SqlDataReader dr = com.ExecuteReader();
            Console.WriteLine("EMPLOYEE DETAILS ARE AS FOLLOWS :");
            Console.WriteLine("Without while loop:");
            int counter = 1;
            Console.WriteLine(dr.HasRows);

            if (dr.HasRows)
            {
                dr.Read();
                Console.WriteLine();
                Console.WriteLine("{0} Employee details :", counter);
                Console.WriteLine("EmpID   : {0}", dr[0].ToString());
                Console.WriteLine("Emp Name : {0}", dr["EmpName"].ToString());
                Console.WriteLine("Dept ID : {0}", dr["DeptID"].ToString());

                Console.WriteLine();
                counter++;
                dr.Read();
                Console.WriteLine();
                Console.WriteLine("{0} Employee details :", counter);
                Console.WriteLine("EmpID   : {0}", dr[0].ToString());
                Console.WriteLine("Emp Name : {0}", dr["EmpName"].ToString());
                Console.WriteLine("Dept ID : {0}", dr["DeptID"].ToString());
                Console.WriteLine();
                counter++;
            }
            dr.Close();

            Console.WriteLine("While loop:");
            dr = com.ExecuteReader();

            counter = 1;
            while (dr.Read())
            {
                Console.WriteLine();
                Console.WriteLine("{0} Employee details :", counter);
                Console.WriteLine("EmpID   : {0}", dr[0].ToString());
                Console.WriteLine("Emp Name : {0}", dr["EmpName"].ToString());
                Console.WriteLine("Dept ID : {0}", dr["DeptID"].ToString());
                Console.WriteLine();
                counter++;

            }
            Console.WriteLine("Re read");
            counter = 1;
            dr.Close();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine();
                Console.WriteLine("{0} Employee details :", counter);
                Console.WriteLine("EmpID   : {0}", dr[0].ToString());
                Console.WriteLine("Emp Name : {0}", dr["EmpName"].ToString());
                Console.WriteLine("Dept ID : {0}", dr["DeptID"].ToString());
                Console.WriteLine();
                counter++;

            }
            con.Close();





        }
    }
}
