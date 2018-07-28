using NUnit.Framework;

namespace ICD_Selenium_Web_Driver
{
    public enum ICDTestType
    {
        SmokeTest,
    }
    public class ICDAttribute : CategoryAttribute
    {   
        public const string SEARCH_ENGINE_SMOKE_TEST = "Search_Engine";

        public ICDAttribute(ICDTestType type) : base($"{ SEARCH_ENGINE_SMOKE_TEST}_{type.ToString()}") { }
        
    }
}

