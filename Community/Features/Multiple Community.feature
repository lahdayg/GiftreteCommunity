Feature: Multiple Community
	As a giftrete web user
   I want to be able to create more than one community on my account
   So that I can have as many people as I want on my accounts

@mytag
Scenario: Multiple Community 
Given I navigate to the site
When  i click  login
And I enter Email "email address
And i enter password
And i click Signin
And i click on community
And i clickon create new
And i enter community name"my 2nd community"
And i enter Community description"my description"
And I click on dropdown 
And i click on community type"my type"
And i click on Location
And i enter Location"my location"
And i switch to Public status
And i click on choosefile 
And i click on create Community
Then i should have more than one comunity on my account