using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WatinExampleProject.Helpers;
using WatiN.Core;

namespace WatinExampleProject.Steps
{
    [Binding]
    public class EnusreThatWhenYouTypeAQueryIntoGoogleThatYouGetAResultBackSteps
    {
        /// <summary>
        /// This class handles the IE browser instances used by the tests below.
        /// </summary>
        private static IEStaticInstanceHelper _ieStaticInstanceHelper;

        /// <summary>
        /// This class contains a series of helper functions for interacting with form elements.
        /// </summary>
        private IBrowserTestHelpers _browserTestHelpers;
        public IE Browser
        {
            get { return _ieStaticInstanceHelper.IE; }
            set { _ieStaticInstanceHelper.IE = value; }
        }

        [Given(@"that the user is on the Google Site")]
        public void GivenThatTheUserIsOnTheGoogleSite()
        {
            _ieStaticInstanceHelper = new IEStaticInstanceHelper();
        }
        
        [Given(@"they want to find the LexisNexis home page")]
        public void GivenTheyWantToFindTheLexisNexisHomePage()
        {
            var url = "http://www.google.co.za";
            Browser.GoTo(url);
            _browserTestHelpers = new BrowserTestHelpers(Browser);
        }
        
        [When(@"they enter a search term of '(.*)'")]
        public void WhenTheyEnterASearchTermOf(string searchTerm)
        {
            _browserTestHelpers.SetTextBoxValue("lst-ib", searchTerm);
        }
        
        [Then(@"the first link on the page should be '(.*)'")]
        public void ThenTheFirstLinkOnThePageShouldBe(string linkText)
        {
            var result = _browserTestHelpers.ReturnInnerHtml("#rso > div.srg > li:nth-child(1) > div > h3 > a");
            Assert.AreEqual(linkText, result);
        }
    }
}
