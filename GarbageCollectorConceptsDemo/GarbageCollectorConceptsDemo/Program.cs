using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;



namespace GarbageCollectorConceptsDemo
{
    class Foo : IDisposable
    {
        private int X;
        public Foo()
        {
            Console.WriteLine("{0}  I am Constructor will allocate or Initialize class object:", X);
        }
        public Foo(int X)
        {
            this.X = X;
            Console.WriteLine("I am Constructor will allocate or Initialize class object: {0} ", X);
        }
        public void Show()
        {
            Console.WriteLine("The values of X :{0}", X);
        }



        public void Dispose()
        {
            Console.WriteLine("Clean up Unmanaged Resource");
            GC.SuppressFinalize(this);//Finalize distructor in VB.NET
        }

        ~Foo()
        {
            Console.WriteLine("I am distructor will free refernce object: {0} ", X);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Foo foo1 = new Foo(1);

            Foo foo2 = new Foo(2);
            using (Foo foo3 = new Foo(3))
            {

            }
            using (Foo foo3 = new Foo(3))
            {

            }
            // UNAMANGED CODE 
            //using (StreamReader sr = new StreamReader("")) // STREAM
            //{

            //}

            using (SqlConnection con = new SqlConnection())// XML
            {

            }

           
        }
    }
}
