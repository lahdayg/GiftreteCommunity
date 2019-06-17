Feature: Search for community
	     As a giftrete web user
        I want to be able to search for a particular community
		So that I can have access to the community account I want

@mytag
Scenario: Search for Community
Given I navigate to the site
When  i click  login
And I enter Email "email address
And i enter password
And i click Signin
And i click on community
And i click on Discover
And i enter community Name
And i click on Search
Then i should be able to see the community