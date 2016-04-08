using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omgtu.CollectionSortExcercise
{
    public static class PersonComparer
    {
        public static int CompareByName(Person leftPerson, Person rightPerson)
        {
            if (leftPerson == null) return -1;
            if (rightPerson == null) return 1;
            int a = leftPerson.Name.CompareTo(rightPerson.Name);
            if (a < 0) a = -1;
            else if (a > 0) a = 1;
            
            return a;
        }

        public static int CompareBySurname(Person leftPerson, Person rightPerson)
        {
            if (leftPerson == null) return -1;
            if (rightPerson == null) return 1;
            int a = leftPerson.Surname.CompareTo(rightPerson.Surname);
            if (a < 0) a = -1;
            else if (a > 0) a = 1;
            return a;
        }

        public static int CompareByGroupNameSurname(Person leftPerson, Person rightPerson)
        {
            if (leftPerson == null) return -1;
            if (rightPerson == null) return 1;
            int a,b,c;
            a = leftPerson.Group.CompareTo(rightPerson.Group);
            if (a < 0) return -1;
            else if (a > 0) return 1;
            b = CompareByName(leftPerson,rightPerson );
            if (b < 0) return -1;
            else if (b > 0) return 1;

            c = CompareBySurname(leftPerson, rightPerson);
            return c;
        }
    }
}
