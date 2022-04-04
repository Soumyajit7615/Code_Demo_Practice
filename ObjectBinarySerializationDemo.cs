using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace FileHandlingStuff
{
    [Serializable]
    public class ClsStudent
    {
        public int RollNo;
        public string Name;
        public ClsStudent(int RollNo, string Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;

        }
    }
    class ObjectBinarySerializationDemo
    {
        static void Main(string[] args)
        {
            ClsStudent std = new ClsStudent(1234, "Nishchitha A");
            IFormatter formatter = new BinaryFormatter();
            Stream outstream =
new FileStream("MyStudent", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(outstream, std);
            outstream.Close();
            Stream Instream =
new FileStream("MyStudent", FileMode.Open, FileAccess.Read, FileShare.Read);
            ClsStudent objstd = (ClsStudent)formatter.Deserialize(Instream);
            Instream.Close();
            Console.WriteLine("Roll No :{0} and Name :{1}", objstd.RollNo, std.Name);
        }
    }
}
