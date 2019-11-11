using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Person
{
    class Tools
    {
        public static string ReadLine(string nick)
        {
            Console.Write("{0}： ", nick);
            return Console.ReadLine();
        }
    }
    class Person
    {
        protected string Id;   //编号
        protected string Name; //姓名
        public Person()
        {
            this.Id = Tools.ReadLine("编号");
            this.Name = Tools.ReadLine("姓名");
        }
        public void show()
        {
            Console.Write("{0,8}{1,8}", this.Id, this.Name);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
    class Teacher : Person, IComparable<Teacher>
    {
        string Professional;
        string Department;
        double JobWage;
        double TeachWage;
        public Teacher()
        {
            this.Professional = Tools.ReadLine("职称");
            this.Department = Tools.ReadLine("部门");
            this.JobWage = Convert.ToDouble(Tools.ReadLine("岗位工资"));
            this.TeachWage = Convert.ToDouble(Tools.ReadLine("教学工资"));
        }
        double wage => JobWage + TeachWage;

        public void show()
        {
            base.show();
            Console.WriteLine("{0,8}{1,9}{2,10}{3,10}{4,8}",
                this.Professional, this.Department, this.JobWage, this.TeachWage, this.wage);
        }
        public int CompareTo(Teacher other)
        {
            return this.wage.CompareTo(other.wage);
        }
    }
    class Student : Person, IComparable<Student>
    {
        string classId;
        double math;
        double english;
        public Student()
        {
            this.classId = Tools.ReadLine("班号");
            this.math = Convert.ToDouble(Tools.ReadLine("数学成绩"));
            this.english = Convert.ToDouble(Tools.ReadLine("英语成绩"));
        }
        double sum => math + english;
        public void show()
        {
            base.show();
            Console.WriteLine("{0,8}{1,10}{2,10}{3,8}",
                this.classId, this.math, this.english, this.sum);
        }
        public int CompareTo(Student other)
        {
            return this.sum.CompareTo(other.sum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            int ch;
            while (true)
            {
                Console.WriteLine("1 添加学生，2 添加教师，3 学生成绩表，4 教师工资表，其它退出");
                ch = Console.Read();
                Console.Clear();
                Console.ReadLine();
                switch (ch)
                {
                    case '1': students.Add(new Student()); break;
                    case '2': teachers.Add(new Teacher()); break;
                    case '3':
                        students.Sort();
                        students.Reverse();
                        Console.WriteLine(students.Count);
                        Console.WriteLine("{0,6}{1,6}{2,6}{3,7}{4,7}{5,5}",
                            "编号", "姓名", "班号", "数学成绩", "英语成绩", "总成绩");
                        foreach (Student student in students)
                            student.show();
                        break;
                    case '4':
                        teachers.Sort();
                        teachers.Reverse();
                        Console.WriteLine(teachers.Count);
                        Console.WriteLine("{0,6}{1,6}{2,6}{3,6}{4,8}{5,7}{6,5}",
                            "编号", "姓名", "职称", "部门", "岗位工资", "教学工资", "总工资");
                        foreach (Teacher teacher in teachers)
                            teacher.show();
                        break;
                    default: Environment.Exit(0); break;
                }
                Console.WriteLine("已保存");
            }
        }
    }
}
