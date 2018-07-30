## Description
The first ICD_Selenium_Web_Driver project contains Page Object Models and TestData. The ICD_test.cs file contains the executable tests. It uses NUnit 3 framework and TestCaseSource attributes for running parameterized tests. This allows for code re-use and testing many permutations of data that can be fed into each test run. 

The second ICDSearch.Specs project integrates SpecFlow NuGet package which extends the Cucumber.io family. It allows users to write tests in human readable language. The syntax used for writing these Behaviour Driven Tests is called Gherkin. Under this project, files ending with the .feature extension represent the feature under test. Scenarios written to test each feature are contained within that file. The step definitions are the actual scripts that run and execute the code behind.

## Usage
This project requires the chromedriver. You can download it [here](http://chromedriver.chromium.org/)
To run tests locally, you must add the chromedriver.exe to your PATH. [You can follow this guide](https://developers.thomsonreuters.com/sites/default/files/How%20To%20Add%20ChromeDriver%20To%20System%20Variables_0.pdf)
1. Clone the repository
2. In the directory where the files were cloned open up the ICD_Selenium_Web_Driver.sln solution file using Visual Studio 2017
3. In the Solution Explorer right-click on the solution and select "Restore NuGet Packages"
4. Build the solution using

    
