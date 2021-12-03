using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terminy.models;
namespace terminy.schematy.Shuffle
{
    public static class PersonelBase
    {       

        public static List<Worker> Mworker(int no)
        {
            List<Worker> Workers = new();
            for (int i = 0; i < no; i++)
            {
                Workers.Add(new Worker(i, "W" + i.ToString()));
            }
            return Workers;
        }
    }
}
