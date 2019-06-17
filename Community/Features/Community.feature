Feature: Community
       As a user of the site
	   i want to be able to create Community group

@mytag
Scenario: Creating Community Group
Given I navigate to the site
When  i click  login
And I enter Email "email address
And i enter password
And i click Signin
And i click on community
And i clickon create new
And i enter community name
And i enter Community description
And I click on dropdown 
And i click on community type
And i click on Location
And i enter Location
And i switch to Public
And i click choose file
And i click on create Community
Then i should be able to create community
