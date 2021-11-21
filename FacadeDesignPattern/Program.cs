using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchingFacade = new SearchEnginFacade();
           var searchingResult= searchingFacade.GetSearchResults("my query");
            Console.WriteLine(searchingResult);

            Console.ReadLine();
        }
    }
}
