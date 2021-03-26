using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public class Student : Man
    {
        private int course;
        private readonly int startYear;
        private int group;

        public Student(string name, int age, int weight, int height,
            int course, int startYear, int group) : base(name, age, weight, height)
        {
            this.course = course;
            this.group = group;
            this.startYear = startYear;
        }

        public int Course { get => course; }
        public int Group { get => group; }
        public int StartYear { get => startYear; }
    }
}
