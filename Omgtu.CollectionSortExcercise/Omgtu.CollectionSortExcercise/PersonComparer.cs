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
            //TODO: Добавить реализацию сравнения по именам

            //Проверка на значения null. Значение null меньше любого другого.
            if (leftPerson == null)
                return -1;
            else if (rightPerson == null)
                return 1;

            //Сохраняем имена студентов в отдельные переменные
            string leftPersonName = leftPerson.Name;
            string rightPersonName = rightPerson.Name;

            //Сравниваем имена и возвращаем результат в виде целого числа
            return String.Compare(leftPersonName, rightPersonName);
        }

        public static int CompareBySurname(Person leftPerson, Person rightPerson)
        {
            //TODO: Добавить реализацию сравнения по именам

            //Проверка на значения null. Значение null меньше любого другого.
            if (leftPerson == null)
                return -1;
            else if (rightPerson == null)
                return 1;

            //Сохраняем фамилии студентов в отдельные переменные
            string leftPersonSurname = leftPerson.Surname;
            string rightPersonSurname = rightPerson.Surname;

            //Сравниваем фамилии и возвращаем результат в виде целого числа
            return String.Compare(leftPersonSurname, rightPersonSurname);
        }

        public static int CompareByGroupNameSurname(Person leftPerson, Person rightPerson)
        {
            //TODO: Добавить реализацию сравнения по именам

            //Проверка на значения null. Значение null меньше любого другого.
            if (leftPerson == null)
                return -1;
            else if (rightPerson == null)
                return 1;

            //Сохраняем группы, в которых числятся студенты
            string leftPersonGroup = leftPerson.Group;
            string rightPersonGroup = rightPerson.Group;

            //Сравниваем названия групп и сохраняем целочисленный результат в переменную
            int compareGroup = String.Compare(leftPersonGroup, rightPersonGroup);

            //Если студенты числятся в разных группах, то возвращаем результат
            if (compareGroup != 0)
                return compareGroup;

            //Сравниваем имена студентов и сохраняем целочисленный результат в переменную
            int compareName = CompareByName(leftPerson, rightPerson);

            //Если у студентов разные имена, то возвращаем результат
            if (compareName != 0)
                return compareName;

            //Сравниваем фамилии студентов и сохраняем целочисленный результат в переменную
            int compareSurname = CompareBySurname(leftPerson, rightPerson);
            //Возвращаем результат
            return compareSurname;
        }
    }
}
