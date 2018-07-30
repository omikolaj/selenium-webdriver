# Description
This test suite contains two sets of tests. The first project ICD_Selenium_Web_Driver contains Page Object Models and TestData. The ICD_test.cs file contains the executable tests. It uses NUnit 3 framework and TestCaseSource attributes used for running parameterized tests. Allowing for code re-use and testing many permutations of data that can be fed into each test run. 

The second project ICDSearch.Specs integrates SpecFlow which extends the Cucumber.io family allowing users to write tests in human readable language. The syntax used for writing these Behaviour Driven Tests is called Gherkin. Under this project, files ending with the .feature extension represent the feature. Scenarios written to test each feature are contained in that file.
The step definitions are the actual scripts that are running and executed the code behind.   
    
