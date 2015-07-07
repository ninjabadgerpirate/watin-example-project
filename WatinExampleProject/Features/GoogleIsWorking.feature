Feature: Enusre that when you type a query into Google that you get a result back
	In order to ensure that Google is still working, we need to ensure that
	When we enter a search query that we get a result back.

Scenario Outline: LexisNexis Website is found
	Given that the user is on the Google Site
	And they want to find the LexisNexis home page
	When they enter a search term of '<SearchTerm>'
	Then the first link on the page should be '<LinkText>'

	Examples: 

	| CaseName         | SearchTerm				|	LinkText															|
	| FindSearchResult | LexisNexis				|	LexisNexis South Africa: Business Management \| Business ...		|