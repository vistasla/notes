using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace automail
{
    class Reflection
    {
      public  Reflection(Object obj) {
            /*Type t = typeof(int);
            System.Reflection.MethodInfo[] Methods = t.GetMethods();
               // System.Reflection.MethodInfo[] Methods = t.;
                foreach (var method in Methods){

                    Console.WriteLine(method.Name);
        }*/
            //ReflectionContext reflectionContext = new ReflectionContext();
                //ReflectionContext reflectionContext;
           // ReflectionContext reflectionContext=new;
          //string strClassName= obj.GetType().ToString();
            Type t = obj.GetType();
            Console.WriteLine(t);
            //System.Threading.shutoff
            // System.Environment.Exit(0);
            // OperatingSystem os = new OperatingSystem();
            // os.
            //System.Diagnostics.Process.Start("shutdown", "-f -s");
            //System.Diagnostics.Process.Start("shutdown", "-s -t 0");
            //System.Diagnostics.Process.Start("IExplore.exe");
            System.Diagnostics.Process.Start("test.exe");
            //t t1 = new t();
            // t.GetMember
            /* System.Reflection.MemberInfo[] Members = t.GetMembers();
             foreach (var Member in Members)
             {

                 Console.WriteLine(Member.Name);
             }*/
            System.Reflection.MemberInfo[] Members = t.GetMember("accountName");
           // Console.WriteLine(Members[0].CustomAttributes);
           // Console.WriteLine(Members[0].GetCustomAttributesData());
            
           /* foreach (var Member in Members)
            {

                Console.WriteLine(Member.Name);
            }*/
        }

    }
}
