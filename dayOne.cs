using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode
{
    class dayOne
    {
        public int Ex1()
        {
            string freq = string.Empty;
            int result = 0;
            using (StreamReader file = new StreamReader(@"C:\Users\ale\Documents\Visual Studio 2015\Projects\AdventOfCode\day1e1.txt"))
            {
                while ((freq = file.ReadLine()) != null)
                {
                    result += Convert.ToInt32(freq);
                }
            }
            return result;
        }
    }
}
