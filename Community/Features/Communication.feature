Feature: Communication
	As a giftrete web user
   I want users to be able to communicate with one another within the community
   So that they can relate with each other easily

@mytag
Scenario: CommunicationwithinCommunity
Given I navigate to the site
When  i click  login
And I enter Email "email address
And i enter password
And i click Signin
And i click on community
And i click on view communities
And i click on  BJCHARITY
And i click on Discussion
And i click on create post
And i enter title
And i write a message
And i click on choose file to add image
And i click on publish
Then my post is published