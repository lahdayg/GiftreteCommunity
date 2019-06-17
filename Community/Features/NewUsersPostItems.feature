Feature: NewUsersPostItems
	As a giftrete web user
   I want new users to be able to share goods on the website 
   So that they can be part of the community


@mytag
Scenario:New Users Post Wanted Items
Given I navigate to the site
When  i click  login
And I enter Email "email address
And i enter password
And i click Signin
And i click Post items
And i enter item name
And i enter item description
And i click dropdowm
And i select item category
And i slect item type
And i enter weight
And i ente location
And i click on Choose file
And i click on Add product