using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorConceptsDemo
{

    class ClsFoo : IDisposable
    {
        private int x;
        public ClsFoo()
        {

        }
        public ClsFoo(int a)
        {
            x = a;
            Console.WriteLine("{0}  I am Constructor will allocate or Initialize class object:", x);
        }
        public void Dispose()
        {
           
            Console.WriteLine("disp : Clean up Unmanaged Resource");
            GC.SuppressFinalize(this); // VN.NET Finalize


        }
        ~ClsFoo()
        {
            Console.WriteLine(" d: Clean up Unmanaged Resource");
            //Dispose(false);
            //In case client forgets to call
            //Disposed , desructor will be invoked  

        }
       

        public void Show()
        {
            Console.WriteLine("The Value of X :{0}", x);

        }
       

    }

    class GCGenerationDemo
    {
        static void Main(string[] args)
        {

            using (ClsFoo Foobj = new ClsFoo(5))
            {
                Foobj.Show();
            }
            using (ClsFoo Foobj = new ClsFoo(5))
            {
                Foobj.Show();
            }



            Console.WriteLine("Inside Main Method");
            ClsFoo obj1, obj2, obj3, obj4;
            obj1 = new ClsFoo(1);
            obj1.Show();
            obj2 = new ClsFoo(2);
            obj2.Show();
            Console.WriteLine("Generation {0} Obj1 :", GC.GetGeneration(obj1));
            Console.WriteLine("Generation {0} Obj2 :", GC.GetGeneration(obj2));
            //obj2.Dispose();
            obj2 = null;
            GC.Collect();
            obj3 = new ClsFoo(3);
            obj3.Show();
            //using (obj3 = new ClsFoo(3))
            //{
            //    obj3.Show();
            //}
            Console.WriteLine("Generation {0} Obj3 :", GC.GetGeneration(obj3));
            Console.WriteLine("Generation {0} Obj1 :", GC.GetGeneration(obj1));
            //obj3.Dispose();
            obj3 = null;
            obj4 = new ClsFoo(4);
            obj4.Show();
            GC.Collect();
            Console.WriteLine("Generation {0} Obj4 :", GC.GetGeneration(obj4));
            Console.WriteLine("Generation {0} Obj1 :", GC.GetGeneration(obj1));
            //Console.WriteLine("Generation {0} Obj3 :", GC.GetGeneration(obj3));

        }
    }
}
