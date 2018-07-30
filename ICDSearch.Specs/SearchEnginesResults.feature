Feature: Search Engines Results
	Search engine results
	for Institutional Cash Distributors search phrases
	should return ICD Portal as a first result


@SearchEngine
Scenario Outline: Search engine returns ICD Portal as first result
	Given a web browser is on the <search engine> page
	When <search engine> executes the search for <phrase>
	Then the first <search engine> result for <phrase> should be "https://icdportal.com/"

	Examples: 
		| example description | phrase                            | search engine           |
		| Google Search For   | "Institutional Cash Distributors" | "http://www.google.com" |
		| Google Search For   | "ICD Portal"                      | "http://www.google.com" |
		| Bing Search For	  | "Institutional Cash Distributors" | "http://www.bing.com"   |