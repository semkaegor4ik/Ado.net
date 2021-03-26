using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public class Man
    {
        private readonly string name;
        private int age;
        private int weight;
        private int height;

        public Man(string name, int age, int weight, int height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public string Name { get => name; }
        public int Age { get => age; }
        public int Weight { get => weight; }
        public int Height { get => height; }

        public override bool Equals(object obj)
        {
            return obj is Man man &&
                   name == man.name &&
                   age == man.age &&
                   weight == man.weight &&
                   height == man.height &&
                   Name == man.Name &&
                   Age == man.Age &&
                   Weight == man.Weight &&
                   Height == man.Height;
        }

        public override int GetHashCode()
        {
            int hashCode = -2116006262;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + age.GetHashCode();
            hashCode = hashCode * -1521134295 + weight.GetHashCode();
            hashCode = hashCode * -1521134295 + height.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + Weight.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "Man's name: " + name + ", age: " + age + ", weight: " + weight + ", height: " + height;
        }

    }
}
