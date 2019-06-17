Feature: AssigningAdministrator
	As a giftrete web user
	I want to be able to assign administrator among the users
    So that the group will be well organised and function well

@mytag
Scenario:AssigninAddministrator
	Given I navigate to the site
    When  i click  login
    And I enter Email "email address
    And i enter password
    And i click Signin
    And i click on community
	And i click on view communities
	And i click on BJ CHARITY
	And i click on Members
	And i click on color dark
	And i click on make admin
	Then i am able to assign administartor
	