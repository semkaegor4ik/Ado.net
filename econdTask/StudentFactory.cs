using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class StudentFactory
    {
        private static StudentValidator studentValidator = new StudentValidator();
       
        public static Student createStudent(string name, int age, int weight, int height,
            int course, int startYear, int group)
        {
            studentValidator.Validate(name, age, weight, height,
            course, startYear, group);
            return new Student(name, age, weight, height,
            course, startYear, group);
        }

        public static Student createStudent(String fileName)
        {
            char[] delimiterChars = { ' ', '\n', ',' };
            string temp;
            using (StreamReader input = new StreamReader(fileName))
            {
                temp = input.ReadToEnd();
            }
            string[] info = temp.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            if (info.Length != 7)
            {
                throw new ArgumentException("The file must have 7 variables");
            }
            studentValidator.Validate(info[0], int.Parse(info[1]), int.Parse(info[2]), int.Parse(info[3]), int.Parse(info[4]), int.Parse(info[5]), int.Parse(info[6]));
            return new Student(info[0], int.Parse(info[1]), int.Parse(info[2]), int.Parse(info[3]), int.Parse(info[4]), int.Parse(info[5]), int.Parse(info[6]));
        }
    }
}

