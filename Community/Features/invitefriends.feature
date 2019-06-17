Feature: Invite new friends
	As a giftrete web user
   I want to be able to invite new friends from my account 
   So that I can create community


@mytag
Scenario: Invite new friends
	Given I navigate to the site
    When  i click  login
    And I enter Email "email address
    And i enter password
    And i click Signin
    And i click on invite
	And i click invite friends
	And i enter name
	And i enter email "email address"
	And i click send invite
	Then i should be able to to invite friends
