using System;

namespace midA_sufiqn
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(">>>>Department Info");
            Console.WriteLine("Enter Department name: ");
            String dn = Console.ReadLine();
            Department d = new Department(dn);
            Console.WriteLine(">>>Course Info");
            String CN, CID;
            Console.WriteLine("Course Name: ");
            CN = Console.ReadLine();
            Console.WriteLine("Course ID: ");
            CID = Console.ReadLine();
            Course C = new Course(CN, CID);
            d.AddCourse(C);
            Console.WriteLine(">>Section Info");
            Console.WriteLine("Enter Section Name: ");
            String s = Console.ReadLine();
            Section A = new Section(s);
            C.AddSection(A);
            Console.WriteLine(">Facultyn Info");
            Console.WriteLine("Enter Faculty Name: ");
            String fn = Console.ReadLine();
            Console.WriteLine("Enter Faculty Id: ");
            String fid = Console.ReadLine();
            Console.WriteLine("Enter Faculty Time: ");
            float ft = Console.Read();
            Faculty fac = new Faculty(fn, fid, ft);
            fac.AddSection(A);

            A.AddTeacher(fac);
            Console.WriteLine("Department name: ");
            d.ShowDInfo();
            C.ShowSectionFaculty();
            Console.WriteLine("\nFaculty object");
            fac.ShowSectionDetails();
            Console.ReadLine();
        }
    }
}
