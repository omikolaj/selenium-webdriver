Feature: Google News Search Results
	Search in Google News
	for Institutional Cash Distributors
	should return ICD Press release as a first result


 @GoogleNewsSearch
Scenario: Google News returns ICD Press Conference as first result
	Given a web browser is on the Google's News tab
	When the search phrase "Institutional Cash Distributors" is executed
	Then the first result for "Institutional Cash Distributors" should be ICD Press release