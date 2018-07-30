﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ICDSearch.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Search Engines Results")]
    public partial class SearchEnginesResultsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SearchEnginesResults.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search Engines Results", "\tSearch engine results\r\n\tfor Institutional Cash Distributors search phrases\r\n\tsho" +
                    "uld return ICD related data as a first result", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search engine returns ICD Portal as first result")]
        [NUnit.Framework.CategoryAttribute("SearchEngine")]
        [NUnit.Framework.TestCaseAttribute("Google Search For", "\"Institutional Cash Distributors\"", "\"http://www.google.com\"", null)]
        [NUnit.Framework.TestCaseAttribute("Google Search For", "\"ICD Portal\"", "\"http://www.google.com\"", null)]
        [NUnit.Framework.TestCaseAttribute("Bing Search For", "\"Institutional Cash Distributors\"", "\"http://www.bing.com\"", null)]
        public virtual void SearchEngineReturnsICDPortalAsFirstResult(string exampleDescription, string phrase, string searchEngine, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SearchEngine"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search engine returns ICD Portal as first result", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given(string.Format("a web browser is on the {0} page", searchEngine), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When(string.Format("{0} executes the search for {1}", searchEngine, phrase), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("the first {0} result for {1} should be \"https://icdportal.com/\"", searchEngine, phrase), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Google News returns ICD Press Conference as first result")]
        [NUnit.Framework.CategoryAttribute("SearchEngine")]
        public virtual void GoogleNewsReturnsICDPressConferenceAsFirstResult()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Google News returns ICD Press Conference as first result", new string[] {
                        "SearchEngine"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("a web browser is on the Google\'s News tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.When("the search phrase \"Institutional Cash Distributors\" is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("the first result for \"Institutional Cash Distributors\" should be ICD Press releas" +
                    "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion


