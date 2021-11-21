using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.SearchEnginMacanishm
{
   public class RetrievingDataMachanism
    {
        public void GetData(int [] indexers)
        {
            Console.Write("Downloading the web with indexers");
            foreach (var item in indexers)
            {
                Console.Write(item+ " ,");
         
            }
            Console.WriteLine();
        }
    }
}
