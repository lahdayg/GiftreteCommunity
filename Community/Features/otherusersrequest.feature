Feature: otherusersrequest
	As a giftrete web user
   I want new web users to be able to request their friends to join the community
   So that that they can benefit from the community
@mytag
Scenario:New User invite friends to the Community
Given I navigate to the site
When  i click  login
And I enter Email 
And i enter my password
And i click Signin
And i click on community
And i click on view communities under members
And i click on DavidSPORT
And i click on Invite
And i enter Name
And i enter email Address
And i click Send Invite
Then my invite is sent 
