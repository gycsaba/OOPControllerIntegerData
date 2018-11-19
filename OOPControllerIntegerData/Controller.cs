using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControllerIntegerDataProcessing
{
    class Controller
    {
        List<int> subjects;
        public Controller()
        {
            subjects = new List<int>();
        }
        public void readFromFile()
        {
            StreamReader sr = new StreamReader("adatok.txt", Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                int a = Convert.ToInt32(line);
                subjects.Add(a);
            }
        }
        public int getNumberOfSubject()
        {
            return subjects.Count();
        }
    }
}
