Feature: AdminAcceptDeline
	As a giftrete web user
   I want the community administrator to be able to accept or decline user request to join the group
   So that the account can well-regulated and monitored


@mytag
Scenario: Admin decline request
Given I navigate to the site
When  i click  login
And I enter Email "email address
And i enter password
And i click Signin
And i click on community
And i click on view communities
And i click on David sport
And i click on Members
And i click on dropdown
And i click on Disaprove
Then request should be pending

Scenario: Admin accept request
Given I navigate to the site
When  i click  login
And I enter Email "email address
And i enter password
And i click Signin
And i click on community
And i click on view communities
And i click on David sport
And i click on Members
And i click on dropdown
And i click on approve
Then status should be member


