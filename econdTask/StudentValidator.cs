using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class StudentValidator
    {
        public void Validate(string name, int age, int weight, int height,
            int course, int startYear, int group)
        {
            if (!name.All(char.IsLetter)
                || age < 10 || age > 100
                || weight < 30 || weight > 300
                || height < 50 || height > 300
                || course < 1 || course > 5
                || startYear > DateTime.Now.Year || startYear < 1500
                || group < 99 || group > 999)
            {
                throw new ArgumentException("incorrect data");
            }
        }
    }
}

