using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle1 = TriangleFactory.CreateTriangle("input1.txt");
                Console.WriteLine(triangle1);
            } catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            } catch(IOException e)
            {
                Console.WriteLine(e.Message);
            } catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
