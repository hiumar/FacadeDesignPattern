using FacadeDesignPattern.SearchEnginMacanishm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
   public class SearchEnginFacade
    {
        private readonly DataIndexers _dataIndexers;
        private readonly GeneratingSnippedMachanism _generatingSnipptMachanism;
        private readonly RetrievingDataMachanism _retrivingDataMachanism;
        private readonly RepresentingResultMachanism _representingResultMachanism;
        public SearchEnginFacade()
        {
            _dataIndexers = new DataIndexers();
            _generatingSnipptMachanism = new GeneratingSnippedMachanism();
            _retrivingDataMachanism = new RetrievingDataMachanism();
            _representingResultMachanism = new RepresentingResultMachanism();
        }

        public string GetSearchResults(string query)
        {
            var index = _dataIndexers.GetIndexersOfStoreData(query);
            _retrivingDataMachanism.GetData(index);
            _generatingSnipptMachanism.GenerateSnippit();
            _representingResultMachanism.PresentData();
            return $"search result for a query{query}.....";

        }
    }
}
