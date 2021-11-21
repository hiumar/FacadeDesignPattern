using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.SearchEnginMacanishm
{
  public class DataIndexers
    {
        public int [] GetIndexersOfStoreData(string query)
        {
            Console.WriteLine($"{query} can be found at index 1,5,8");
            return new[] { 1, 5, 8 };
        }
    }
}
