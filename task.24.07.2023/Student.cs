#region TASK1

using System;
namespace task._24._07._2023
{
	internal class Student
    { 
        public string Name;
        public string SurName;
        public string Group;
        public bool IsGraduated;
        public byte Point;

    public Student(string name, string surName, string group, bool isGraduated, byte point)
		{
            Name = name;
            SurName = surName;
            Group = group;
            IsGraduated = isGraduated;
            Point = point;
		}
    public void Task3()
        {
            //Console.WriteLine(string.Concat(Name," ", SurName," ", Group," ", IsGraduated," ",));
            Console.WriteLine($"Name of student:{Name},Surname of student:{SurName},Group of student:{Group},Is stdent graduated:{IsGraduated},Point of student:{Point}");
            if (IsGraduated)
            {
                Console.WriteLine("This student was graduated");
            }
            else
            {
                Console.WriteLine("This student was not graduated");
            }
        }
    public void Task2()
        {
            Console.WriteLine($"Name of student:{Name},Surname of student:{SurName}");
        }
    public void Task4()
        {
            if (Point > 80)
            {
                Console.WriteLine("This studen can participate in the next exam");
            }
            else
            {
                Console.WriteLine("This student can not participate in the next exam");
            }
        }
	}
}
#endregion
