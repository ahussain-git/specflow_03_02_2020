using System;

namespace specflow_03_02_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SpecFlowFeature1Steps _call = new SpecFlowFeature1Steps();
            _call.GivenIHaveNavigatedToTheGoogleSearchPage();
            _call.WhenIEnterTheWordSpecflow();
            _call.WhenIClickTheSearchButton();
            _call.ThenIShouldBeShownTheSearchResultsPage();
        
        }
    }
}
