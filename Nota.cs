using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cine_Alfa
{
    internal class Nota
    {
        public static int id_u { get; set; }

        public static void id(int id_u)
        {
            Nota.id_u = id_u;
        }

        public static int op {  get; set; }
        
        public static void dato1(int op)
        {
            Nota.op = op;
        }

        public static string hora1 {  get; set; }
        public static string hora2 { get; set; }
        public static string hora3 { get; set; }
        public static string hora4 { get; set; }

        public static void dato2(string hora1, string hora2, string hora3, string hora4)
        {
            Nota.hora1 = hora1;
            Nota.hora2 = hora2;
            Nota.hora3 = hora3;
            Nota.hora4 = hora4;
        }

        public static int op2 { get; set; }

        public static void dato3(int op2)
        {
            Nota.op2 = op2;
        }

        public static int n1 { get; set; }
        public static int n2 { get; set; }
        public static int n3 { get; set; }

        public static void dato4( int n1, int n2, int n3)
        {
            Nota.n1 = n1;
            Nota.n2 = n2;
            Nota.n3 = n3;
        }

        public static char sal {  get; set; }

        public static void dato5(char sal)
        {
            Nota.sal = sal;
        }




    }
}
