using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvent
{
    class Sort
    {
        public void Desc(string[] surnames)
        {
            string temp;
            for (int i = 0; i < surnames.Length; i++)
            {
                for (int j = i + 1; j < surnames.Length; j++)
                {
                    if (surnames[i][0] < surnames[j][0])
                    {
                        temp = surnames[i];
                        surnames[i] = surnames[j];
                        surnames[j] = temp;
                    }
                }
            }
            foreach(var name in surnames) 
            { 
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
        public void Asc(string[] surnames)
        {
            string temp;
            for (int i = 0; i < surnames.Length; i++)
            {
                for (int j = i + 1; j < surnames.Length; j++)
                {
                    if (surnames[i][0] > surnames[j][0])
                    {
                        temp = surnames[i];
                        surnames[i] = surnames[j];
                        surnames[j] = temp;
                    }
                }
            }
            foreach (var name in surnames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
