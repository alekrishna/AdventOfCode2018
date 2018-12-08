using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode
{
    static class dayOne
    {
        public static int Ex1()
        {
            string freq = string.Empty;
            int result = 0;
            List<int> partial = new List<int>();
            partial.Add(result);
            using (StreamReader file = new StreamReader(@"C:\Users\ale\Documents\Visual Studio 2015\Projects\AdventOfCode\day1e1.txt"))
            {
                while ((freq = file.ReadLine()) != null)
                {

                    partial.Add(result += Convert.ToInt32(freq));
                }
            }
            return partial.Last<int>();
        }
        public static int? Ex2()
        {
            int? found = null;
            string freq = string.Empty;
            int result = 0;
            List<int> partial = new List<int>();
            partial.Add(result);
            List<int> numsToSum = new List<int>();
            using (StreamReader file = new StreamReader(@"C:\Users\ale\Documents\Visual Studio 2015\Projects\AdventOfCode\day1e1.txt"))
            {
                while ((freq = file.ReadLine()) != null)
                {
                    numsToSum.Add(Convert.ToInt32(freq));
                    //partial.Add(result += Convert.ToInt32(freq));
                }
            }
            while (found == null)
            {
                foreach (var n in numsToSum)
                {
                    var r = partial.Last<int>() + n;
                    ////partial.Add(r);
                    int lio = partial.LastIndexOf(r);
                    if (partial.Contains(r))
                    {
                        found = r;
                        break;
                    }
                    else
                    {
                        partial.Add(r);
                    }
                }
            }
            return found;
        }

    }
}