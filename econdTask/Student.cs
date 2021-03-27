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

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   base.Equals(obj) &&
                   Name == student.Name &&
                   Age == student.Age &&
                   Weight == student.Weight &&
                   Height == student.Height &&
                   course == student.course &&
                   startYear == student.startYear &&
                   group == student.group &&
                   Course == student.Course &&
                   Group == student.Group &&
                   StartYear == student.StartYear;
        }

        public override int GetHashCode()
        {
            int hashCode = -1339112217;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + Weight.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            hashCode = hashCode * -1521134295 + course.GetHashCode();
            hashCode = hashCode * -1521134295 + startYear.GetHashCode();
            hashCode = hashCode * -1521134295 + group.GetHashCode();
            hashCode = hashCode * -1521134295 + Course.GetHashCode();
            hashCode = hashCode * -1521134295 + Group.GetHashCode();
            hashCode = hashCode * -1521134295 + StartYear.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "Student's name: " + name + ", age: " + age + ", weight: " + weight + ", height: " + height +
                ", course: " + course + ", startYear: " + startYear + ", group: " + group;
        }
    }
}
