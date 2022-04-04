using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace GarbageCollectorConceptsDemo
{
    class A
    {
        public A()
        {
            Console.WriteLine("1. I am constructor of A:");
        }
        ~A()
        {
            Console.WriteLine("1. I am distructor of A:");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("2. I am constructor of B:");
        }
        ~B()
        {
            Console.WriteLine("2. I am distructor of B:");
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine("3. I am constructor of C:");
        }
        ~C()
        {
            Console.WriteLine("3. I am distructor of C:");
        }
    }

    class MyClass : IDisposable
    {
        public MyClass()
        {

        }
        ~MyClass() {
            Console.WriteLine("I am dist i will clear unmanaged resource:");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);// vb.net Finalize
            Console.WriteLine("I am dispose i will clear unmanaged resource:");

        }
    }
    class InheritanceConceptCD
    {
        static void Main(string[] args)
        {
            C c = new C();

           //ADO-XML (SQLCLIENT) , IO, XML 
            using (MyClass my = new MyClass())
            {

            }
            using (MyClass my = new MyClass())
            {

            }

            using(StreamWriter sw = new StreamWriter("somefile.txt"))
            {
                sw.WriteLine("Hello world!");

            }
            using (SqlConnection con = new SqlConnection())// XML
            {

            }


        }
    }
}
