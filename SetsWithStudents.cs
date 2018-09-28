using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Policy;


namespace MiroslavD
{
    public class HashSetsWithStudents
    {
       public static string GetStudentList(IEnumerable<string> students)
       {
           string result = string.Empty;
           foreach(string student in students)
           {
               result += student + ",";
           }
           if(result != string.Empty)
           {
               result = result.TrimEnd(',', ' ');
           }
           return result;
       }
       public static void Main()
       {
           HashSet<string> GratestStudents = new HashSet<string>();
           GratestStudents.Add("M. Dimitrov");
           GratestStudents.Add("J. Dimitrov");
           GratestStudents.Add("H. Dimitrov");
           GratestStudents.Add("L. Dimitrov");
           HashSet<string> SilverLightStudents = new HashSet<string>();
           SilverLightStudents.Add("M. Dimitrov");
           SilverLightStudents.Add("V. Dimitrov");
           SilverLightStudents.Add("O. Dimitrov");
           HashSet<string> allStudents = new HashSet<string>();
           allStudents.UnionWith(GratestStudents);
           allStudents.UnionWith(SilverLightStudents);
           HashSet<string> intersectStudents = new HashSet<string>(GratestStudents);
           intersectStudents.IntersectWith(SilverLightStudents);

           Console.WriteLine("Gratest students: " + GetStudentList(GratestStudents));
           Console.WriteLine("Silver light students: " + GetStudentList(SilverLightStudents));
           Console.WriteLine("AllStudents: " + GetStudentList(allStudents));
           Console.WriteLine("Intersect students: " + GetStudentList(intersectStudents));

           Console.WriteLine();
       }
    }
}


